var express = require('express');
var path = require('path');
var favicon = require('serve-favicon');
var logger = require('morgan');
var cookieParser = require('cookie-parser');
var bodyParser = require('body-parser');

var mongoose= require('mongoose');
var fs= require('fs');
var index = require('./routes/index');
var users = require('./routes/users');
var app = express();
//string de conexion db
var options = { server: { socketOptions: { keepAlive: 1 } } };
var uri= 'mongodb://user:database1@ds125262.mlab.com:25262/abrespol';


//conectar db
mongoose.connect(uri, options);

//base de datos
var db = mongoose.connection;

//conexion correcta
mongoose.connection.on('connected', function (err) {
  console.log("Conectado a la base de datos usando: " + uri);
});

// Error handler db
mongoose.connection.on('error', function (err) {
  console.log(err);
});

// Reconectar cuando se cierre db
mongoose.connection.on('disconnected', function () {
   self.connectToDatabase();
});

//Cargando modelos
fs.readdirSync(__dirname + '/models').forEach(function(filename){
	if (~filename.indexOf('.js')) require(__dirname + '/models/'+ filename);
});

// view engine setup
app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'jade');

// uncomment after placing your favicon in /public
//app.use(favicon(path.join(__dirname, 'public', 'favicon.ico')));
app.use(logger('dev'));
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: false }));
app.use(cookieParser());
app.use(express.static(path.join(__dirname, 'public')));

app.use('/', express.static(path.join(__dirname, './')));
app.use('/usuario', express.static(path.join(__dirname, './user')));


app.get('/login/:usuario/:password', function(req, res){
mongoose.model('usuarios').find({username: req.params.usuario}, function(err, users){
		if(req.params.password==users[0].password){
			res.send(users[0].rol);
		} else{
			res.sendStatus(404); 
		}
});

});

// catch 404 and forward to error handler
app.use(function(req, res, next) {
  var err = new Error('Not Found');
  err.status = 404;
  next(err);
});

// error handler
app.use(function(err, req, res, next) {
  // set locals, only providing error in development
  res.locals.message = err.message;
  res.locals.error = req.app.get('env') === 'development' ? err : {};

  // render the error page
  res.status(err.status || 500);
  res.render('error');
});

module.exports = app;
