Para descargar el selenium grid https://selenium-release.storage.googleapis.com/4.0-beta-4/selenium-server-4.0.0-beta-4.jar

Para iniciar el grid en modo standalone sería
java -jar nombre-del-jar.jar standalone

Para iniciar en modo configuración hub 
java -jar nombre-del-jar.jar hub

Para agregar nodos al hub
java -jar nombre-del-jar.jar node --grid-url http://<IP HUB>:4444