
$(function () {
    var datetimedefault = {
        format: 'YYYY-MM-DD',//日期格式化，只显示日期
        locale: 'zh-CN',      //中文化
        maxDate: '2017-01-01',//最大日期
        minDate: '2010-01-01', //最小日期
        viewMode: 'days',
        defaultDate: false,
        disabledDates: false,
        enabledDates: false,
    };

    $.each($(".date"), function (index, item) {
        var data = $(item).data();
        $.each(data, function (key, value) {
            for (i in datetimedefault) {
                if (key == i.toLowerCase()) {
                    datetimedefault[i] = value;
                    break;
                }
            }
        });
        //var param = $.extend({}, datetimedefault, data || {});

        $(item).datetimepicker(datetimedefault);
    });
});