# imprime 2.0

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
https://mega.co.nz/#fm/KQgEBS6K
Carpeta: sistemas y soporte it>desarrollo>intranet>cr xi merge modules

 Se deben agregar al proyecto de instalacion , una vez compilado el proyecto.




