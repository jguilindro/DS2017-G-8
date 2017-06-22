var App = new Vue({
  mounted: function(){
  
  },
  el: '#app',
  data: {
    usuario: '',
    password: ''
  },
  methods: {
	  	realizarLogin: function(){
	  		var self= this;
	  		var urlApi='/login/'+ this.usuario+ '/'+ this.password;
			$.ajax({
			 url: urlApi,
			 success: function(res){
			 	console.log(res);
			 	if (res.rol=="administrador"){
			 		window.location="/admin";
			 	}else if (res.rol=="cliente"){
			 		window.location="/usuario";
			 	}else if (res.rol=="asistente"){
			 		window.location="/asistente/"+res.restaurante;
			 	}
			 	
			 }
				});

	  	}
	}
});

