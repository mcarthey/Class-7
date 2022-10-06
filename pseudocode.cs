Program.cs

	Media media = null;
	if 1 (Video)
		media = new Video();
	if 2 (Show)
		media = new Show();
	if 3 (Movie)
		media = new Movie();

	media.Read();
	media.Display(); // polymorphism

Media
	id
	title
Video
	format
	region[]
Show
	region
	writers[]
Movie
	genres[]
	
Abstract Class
	abstract void Display();
	abstract void Read();
	
Read	
	movies.csv
	shows.csv
	videos.csv

List<string> list.ToArray()
string[] arrayString.ToList()
