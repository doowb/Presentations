module.exports = (function() {

	var express = require('express');
	var app = express();

	app.configure(function() {
	    app.use(express.favicon());
	    app.use(express.logger('dev'));
	    app.use(express.cookieParser());
	    app.use(express.bodyParser());
	    app.use(express.methodOverride());
	    app.use(express.session({ secret: 'omedelbmessa' }));
	    app.use(app.router);
	    app.use(express.static(__dirname + '/public'));
	});

	app.configure('development', function() {
		app.use(express.errorHandler());
	});

	var port = 12345;

	app.listen(port);

	console.log('Application Server running on port ' + port + '...');

})();