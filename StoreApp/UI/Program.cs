﻿using UI;

string connect = File.ReadAllText("./connectionString.txt");

//dependency injection
IRepo _repo = new DataStorage(connect);
IBL _bl = new BusinessL(_repo);
//new oldMainMenu(bl).homeMenu();
new MenuFactory().gotoMenu("main").Start();
