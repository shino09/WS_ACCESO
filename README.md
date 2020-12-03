Web services asmx c# , encargado de consultar en base de datos por informacion del cliente para realizar su logue remoto.

Recibe correo usuario y password de la pagina de login.
Pregunta en la base de datos que cliente esta logueandose y que web services debe consumir loguearse con el correo recivido.
Consume web services, donde envia el usuario, la password encriptada y una key que servira para su desenciptacion.
Recibe una respuesta correcta o erronea y al devuelve a la pagina de login.
Autoria: Ivan Sobarzo

PD: se elimino webconfig porque tenia informacion sensibles de acceso a base de datos.
