# Flappy Eagle

# vídeo
https://youtu.be/Du6xaz4cCpg

# Participantes:
- Jonas Alves de Sena Neto

# Próposito do Projeto

Sendo uma releitura em 3D do famoso e memorável jogo para celular, Flappy bird. Flappy Eagle vem com a intenção de renovar e modificar os ares do antigo jogo.
Fiz esse jogo com a intenção de mostrar que a disciplina de LP2 tem tudo a ver com o mundo do desenvolvimento de jogos e expor que essa área deveria ser mais explorada 
dentro da UFRN. Além de claro me desafiar e aprender mais sobre a ferramenta e a linguagem que pretendo trabalhar profissionalmente, no caso Unity e C# respectivamente.

# Organização do Projeto
![Diagrama](https://github.com/imetropoledigital/trabalho-final-flappy-bird-team/blob/main/Flappy-Eagle%20Diagrama%20de%20classes.png)

Na unity todas as classes herdam da super classe MonoBehaviour.

- A classe GameController, controla os aspectos gerais do jogo como pontuação, chamada de game over e start do jogo.

- A classe CameraMoviment é responsável por travar os eixos da câmera.

- A classe BirdMoviment é quem controla os aspectos de movimentação e animação do pássaro.

- A classe SpawnPipes é a responsável por instanciar os prefabs(obejtos que será clonados) e também por executar a geração procedural que dará dinamicidade ao jogo por
meio das diferentes alturas em que a abertura para o pássaro passar.

- A classe PipesMoviment implementar a interface funcional com parâmetro genérico ICountable<T> e é quem gerencia a progressão de velocidade dos canos aumentando a 
dificuldade do jogo ao passar do tempo.

- A classe Points implementa a interface ICountable<T> e é responsável por detectar caso o jogador consiga passar pela abertura e contar o ponto

- A classe UIGameOver implementa a classe IClickable e é responsável por resetar o jogo caso o jogador aperte no botão de resetar

# Build e Execute

Segue o passo a passo para abrir o jogo na unity e poder modificar os objetos, componentes, cenas e tudo que for desejado:
1. Instale a Unity
2. selecione a pasta clonada como novo projeto e abra com a unity
3. Vá em Assets > Scenes e abra a cena chamada StartLevel
4. Aperte em play para jogar

Por prática se quiser apenas jogar o jogo, pode apenas executar o Flappy Eagle.exe e já abrirá o jogo normalmente. Ou você pode acessar
https://jadsn.itch.io/flappy-eagle e fazer o download do executável por lá.
