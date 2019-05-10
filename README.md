# imprime 2.0

## Path de instalacion
- Para ver carpeta de instalación, abrir los procesos, dentro de la solapa “Procesos”, botón derecho sobre el proceso de cedir.exe, elegir opción “Abrir ubicación del archivo”

Si estas en windows XP, esta dentro de la carpeta `C:\Documents and Settings\username\LocalSettings\Apps\2.0\XGAHSGSAAHAJ`
NOTA: puede haber varias carpetas con el nombre `XBASGASDASXXX` (por ej), ver cual tiene mas carpetas dentro, y ubicar ahi una carpeta llamada `imprime......`
Tener en cuenta que el path puede estar en castellano, en vez de LocalSettings seria Configuracion Local.

Si con esto no es sufciente para encontrar la carpeta de instalacion, buscar en google con “click once intallation path” o con esto lo resolvi: https://stackoverflow.com/questions/2359026/how-to-get-folder-path-for-clickonce-application 
- Versiones de CR para cada version de VS: https://www.tektutorialshub.com/download-crystal-reports-for-visual-studio/
- Este link te habla de las diferentes versiones y es donde dice que la ultima version de service pack con libreria version 13.0.2000.0 es la sp20: https://wiki.scn.sap.com/wiki/display/BOBJ/Crystal+Reports%2C+Developer+for+Visual+Studio+Downloads

Mas info en el doc Instalar cedir intranet entorno

## instalacion de cr xi

Debido a que en el reporte necesitamos pasar como referencia un atributo imagen, nos vemos obligados a utilizar una version de crystal reports que nos brinde esta posibilidad.

¿Por qué adjuntamos estas notas?
CR x viene instalado por defecto en visual studio 2005. Por esta razon, debimos actualizar el cr a la version xi R2 , la cual nos brinda la posibilidad de pasar imagenes como parametros a nuestros informes. 

¿Existen conflictos con esta version?
al instalar esta nueva version, las librerias de cr x son eliminadas, y se instalan las nuevas librerias. 
Esto hace que las referencias en el proyecto deban ser cambiadas. 

*** Notas a tener en cuenta
Cuando utilizamos cr x en otros proyectos, podemos compilar el proyecto y utilizar los ejecutables de la carpeta bin para poder instalr en las maquinas clientes. No era necesario tener un proyecto setup en nuestra solucion.

Al momento de instalar cr xi, esto no es posible. 
Debemos instalar en las maquinas cliente, desde un proyecto setup. 

¿Por que es esto?
Debido a que cr xi no viene mas integrado con visual studio a partir de la version 2008, tenemos que incluir en un proyecto setup, los merge modules necesarios para que se instalen las librerias necesarias en las maquinas cliente, y de este modo, poder ver los reportes sin problemas. 

los nuevos archivos mege modules estan dispondibles en mega
https://mega.co.nz/
Carpeta: sistemas y soporte it>desarrollo>intranet>cr xi merge modules

 Se deben agregar al proyecto de instalacion , una vez compilado el proyecto.


Respecto a la estructura que debe existir en la pc: 
al momento de instalar el programa, se utilizan archivos de sonido predeterminados de windows xp . 

Ademas, se debe tener en pc una particion "D:\CAPTURAS\".
Crear  "D:\CEDIR CAPTURADOR\ding.wav", y guardar aqui el paquete instalador, para futuro uso











