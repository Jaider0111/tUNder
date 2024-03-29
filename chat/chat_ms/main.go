package main

import (
	"chat_ms/configs"
	"chat_ms/routes"

	"github.com/gin-gonic/gin"
)

func main() {
	//Se crea el servidor
	router := gin.Default()

	//Conexion a la base de datos
	configs.ConnectDB()

	//Se definen las rutas
	routes.ChatRoute(router)
	routes.MessageRoute(router)

	//Se configura y se ejecuta el servidor
	configs.ConfigureAndRunServer(router)
}
