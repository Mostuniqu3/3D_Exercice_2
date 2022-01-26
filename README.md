# 3D_Exercice_2
 Exercice 2 du cours de Programmation 3D

- Déplacement clavier/souris via les touches définies dans Unity
- Clique gauche pour faire apparaître une balle, la vitesse des balles et leur fréquence d'apparition lorsque clique gauche reste enfoncé sont parametrables sur le GameObject BulletParent
- Lorque la cible est touchée par une balle, elle se téléporte à un autre endroit dans une range définie sur son GameObject
- Les balles sont sur leur propre layer, elles ne collisionent qu'avec la cible et le sol, le personnage est sur son propre layer et ne collisionne qu'avec le sol
- Le personnage consiste d'un tronc relié en fix joint avec ses deux bras et ses deux jambes et d'un character joint pour relier la tête
- Le script de mouvement est sur le GameObject Personnage. Il ne fait pivoter que la tête lors d'un mouvement de souris. Pour éviter que le personnage de tombe nous avons dû créer un script PreventFalling qui garde sa tête toujours à la même hauteur.
