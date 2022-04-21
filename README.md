# deep-neural-network-project
Proyecto final de 5to año en la especialidad de Computación, asignaturas: Proyecto Informático, Análisis de Sistemas, Programación.

Tema: Prediccion de sismos/terremotos en una zona determinada (California).

A continuación explicaré las partes fundamentales de este proyecto.

Toda la documentación que fui haciendo mientras avanzaba (DCU, PERT-GANT, DFD, DER, DICCIONARIO DE DATOS, MARCO TEÒRICO, OPERACIONALIZACION, VISTA DE CLASES, VISTA DE SECUENCIAS, SET DE DATOS, ETC) la podrán encontrar en las diferentes subcarpetas de este repositorio.

------------------------------------------------------------------------------------------------------------------------------------------------------------------------

En este analisis influyen varios factores como la vulnerabilidad de la zona a catastrofes
naturales, como tambien la amenaza. Estos datos son recopilados de registros hechos a lo largo de la historia.

Bases teóricas: Para la prediccion de este fenomeno, el sistema estara compuesto por una red neuronal densa, esta será entrenada con un set de
datos proveniente de registros de sismos por zonas a lo largo de la historia, incluyendo su localizacion, magnitud, profundidad, fecha, hora local entre
otros indicadores.
Estos datos sísmicos sobre la magnitud, los tiempos y las réplicas de un terremoto, al ser analizados por esta red neuronal pueden revelar patrones
sísmicos que, sin esa perspectiva a gran escala que permite la inteligencia artificial, no serían visibles.
Existen muchos métodos que intentan predecir terremotos de manera más o menos afortunada. Este tiene la ventaja de predecir terremotos en una
zona determinada muy precisa y con una magnitud con una baja incerteza. Es decir, cumple con los requisitos que debe tener toda afirmación para
ser una verdadera predicción de terremotos (tiempo y magnitud).
