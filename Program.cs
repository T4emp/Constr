Music music = new Music();
Music crtmusic = new Music("Фолк - музыка, Джаз, Кантри, Хип-хоп");
Music hiphopcrtmusic = new Music("Хип-хоп", "Чикано-рэп, Фристайл-рэп, Гангста-рэп");

music.Print();
crtmusic.Print();
hiphopcrtmusic.Print();

music.name1 = "Шансон";
music.name2 = "Классический шансон, Новый шансон";
music.Print();