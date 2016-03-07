
#JARKOV 37


## Introducción

 Járkov 37 es un juego cooperativo entre dos jugadores, los cuales se enfrentarán a
múltiples encrucijadas en las que tendrán que escoger bien si quieren sobrevivir.
En esta aventura conversacional las decisiones de los jugadores serán las que marquen
el camino, ya que a partir de éstas, el juego terminará de una manera o de otra.
El servidor será el que gestione todo y los dos clientes usados serán para albergar a
nuestros jugadores.


## Paso de mensajes

Una vez iniciado el juego se empezará a contar la historia para que los jugadores
se pongan en situación y entiendan de qué va a tratar esta historia interactiva.
Después de una breve introducción empezará la toma de decisiones por parte de ambos
jugadores. El servidor le dará 2 posibles caminos para escoger al jugador y éste tendrá
que tomar uno de ellos .

```
<= $Situacion por parte del servidor dando dos posibles opciones$
=> $El jugador decide y le manda la opcion escogida$
<= $Respuesta por parte del servidor con otra situacion en base a la opcion escogida anteriormente por el usuario$
```

Una vez que el primer jugador decide, será el turno del segundo jugador el cual
tendrá que hacer lo mismo. Aqui entra la parte compleja. Los dos jugadores deberan escoger la misma opcion para
ir por ese camino. Si alguno de los dos escoge distinto del otro, el juego escogera la opcion mas beneficiosa para
que sean capaces de llegar al final.

Así seguirá la historia hasta que uno de los dos jugadores cometa una error y se
termine el juego o hasta que los dos consigan llegar al final vivos y ganen.


## Intrucciones

Para iniciar el juego solo hay que abrir un servidor y dos clientes. Una vez conectemos le servidor podremos empezar a jugar. 
