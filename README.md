Each Controller gets a folder in the Views folder with the name same as the Controller but without the Controller Suffix. Thus, for the HomeController, there is a folder with the name Home in the Views folder.

Each Action method in the Controller gets a file of its own, named same as the Action method. Thus for the index method of the HomeController, there’s a file with the name index.cshtml in the Views/Home folder

The MVC Controller Action method invokes the View by using the method View(). The MVC then looks for the View in the Views/<Controller>/ folder and chooses the <ActionMethod>.cshtml as the view.

"# first_MVC" 
