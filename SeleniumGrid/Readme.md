Para descargar el [Selenium Grid](https://selenium-release.storage.googleapis.com/4.0-beta-4/selenium-server-4.0.0-beta-4.jar)


## Comandos
Para iniciar el grid en modo standalone sería
```
java -jar nombre-del-jar.jar standalone
```
Para iniciar en modo configuración hub
``` 
java -jar nombre-del-jar.jar hub
```
Para agregar nodos al hub
```
java -jar nombre-del-jar.jar node --grid-url http://<IP HUB>:4444
```


## Documentanción original
En este [enlace](https://www.selenium.dev/documentation/en/grid/grid_4/setting_up_your_own_grid/) puedes encontrar la documentación original de Selenium.
