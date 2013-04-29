(function ($, _) {
    var helpers = window.helpers = window.helpers || {};

    helpers.getData = function (id, callback) {
        $.get('api/data/' + id).success(function (data) {
            callback(data);
        });
    };

    $(function () {
        console.log('helpers loaded');
    });
})(window.$, window._);
