var mongoose= require('mongoose');
var Schema= mongoose.Schema;

var usuariosSchema = new Schema({nombre: String, username: String, password: String, rol: String});
mongoose.model('usuarios', usuariosSchema);