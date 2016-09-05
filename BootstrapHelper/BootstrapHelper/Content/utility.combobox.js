

(function ($) {
    //1.定义jquery的扩展方法combobox
    $.fn.combobox = function (options, param) {
        if (typeof options == 'string') {
            return $.fn.combobox.methods[options](this, param);
        }
        //2.将调用时候传过来的参数和default参数合并
        options = $.extend({}, $.fn.combobox.defaults, options || {});
        //3.添加默认值
        var target = $(this);
        target.attr('valuefield', options.valueField);
        target.attr('textfield', options.textField);
        target.empty();
        var option = $('<option></option>');
        option.attr('value', '');
        option.text(options.placeholder);
        target.append(option);
        //4.判断用户传过来的参数列表里面是否包含数据data数据集，如果包含，不用发ajax从后台取，否则否送ajax从后台取数据
        if (options.data) {
            init(target, options.data);
        }
        else {
            //var param = {};
            options.onBeforeLoad.call(target, options.param);
            if (!options.url) return;
            if (typeof options.param == "string") {
                options.param = JSON.parse(options.param);
            }
            $.getJSON(options.url, options.param, function (data) {
                init(target, data);
            });
        }
        function init(target, data) {
            $.each(data, function (i, item) {
                var option = $('<option></option>');
                option.attr('value', item[options.valueField]);
                option.text(item[options.textField]);
                target.append(option);
            });
            options.onLoadSuccess.call(target);
        }
        target.unbind("change");
        target.on("change", function (e) {
            if (options.onChange)
                return options.onChange(target.val());
        });
    }

    //5.如果传过来的是字符串，代表调用方法。
    $.fn.combobox.methods = {
        getValue: function (jq) {
            return jq.val();
        },
        setValue: function (jq, param) {
            jq.val(param);
        },
        load: function (jq, url) {
            $.getJSON(url, function (data) {
                jq.empty();
                var option = $('<option></option>');
                option.attr('value', '');
                option.text('请选择');
                jq.append(option);
                $.each(data, function (i, item) {
                    var option = $('<option></option>');
                    option.attr('value', item[jq.attr('valuefield')]);
                    option.text(item[jq.attr('textfield')]);
                    jq.append(option);
                });
            });
        }
    };

    //6.默认参数列表
    $.fn.combobox.defaults = {
        url: null,
        param: null,
        data: null,
        valueField: 'value',
        textField: 'text',
        placeholder: '请选择',
        onBeforeLoad: function (param) { },
        onLoadSuccess: function () { },
        onChange: function (value) { }
    };

    //这一段是新加的，在页面初始化完成之后调用初始化方法
    $(document).ready(function () {
        $('select').each(function () {
            var $combobox = $(this);
            $.fn.combobox.call($combobox, $combobox.data());
        })
    });

})(jQuery);