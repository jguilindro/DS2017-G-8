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
			 	if (res=="administrador"){
			 		window.location="/admin";
			 	}else if (res=="cliente"){
			 		window.location="/usuario";
			 	}else if (res=="asistente"){
			 		window.location="/asistente";
			 	}
			 	
			 }
				});

	  	}
	}
});

