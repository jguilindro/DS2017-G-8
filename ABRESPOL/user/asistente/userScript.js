var App = new Vue({
  mounted: function(){
    //Inicializaciones de Materializecss
    $('select').material_select();
  },
  el: '#app',
  data: {
    todoElMenu: $.grep(info, function( n, i ) {
  return n.nombre===window.location.href.toString().split('/')[4];
	}),
    filteredMenu: $.grep(info, function( n, i ) {
  return n.nombre===window.location.href.toString().split('/')[4];
	}),
    facultad: "",
    textoFiltro: ""
  },
  methods: {
	  	cambiarCategoria: function(){
	  		alert("asdasd");
	  	}
	}

});

$(".logout").click(function(){
	window.location.href = '/index.html';
})

$("#categoria").change(function(){
	App.facultad = $(this).val()
	if (App.facultad != "")
		App.filteredMenu = App.todoElMenu.filter(filtrarFacultad);
	else
		App.filteredMenu = App.todoElMenu;
})

$("#plato").on("input", function(){
	App.textoFiltro = this.value;
	App.filteredMenu = App.todoElMenu.filter(filter);
	console.log(App.filteredMenu)
})

function filter(menu){
	var nombre = menu.nombre.match(App.textoFiltro);
	var entrada = menu.entrada.nombre.match(App.textoFiltro);
	var fuerte = menu.Fuerte.nombre.match(App.textoFiltro);
	var postre = menu.Postre.nombre.match(App.textoFiltro);

	if(nombre != null || entrada != null || fuerte != null || postre != null)
		return true
	else
		return false
}

function filtrarFacultad(menu){
	return menu.Lugar == App.facultad
}

function filtrarRestaurante(menu){
	return menu.nombre ==  window.location.href.toString().split('/')[3];
}