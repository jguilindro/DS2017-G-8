$("#inicio").click(function(){
	var usuario = $("#user").val();
	var password = $("#pass").val();

	if(usuario == "user" && password == "user"){
		window.location.href = 'user/usuario.html';
	}

	if(usuario == "asistente" && password == "asistente"){
		window.location.href = 'asist/asistente.html';
	}
})
