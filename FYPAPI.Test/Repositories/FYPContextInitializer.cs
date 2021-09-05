using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FYPAPI.Infrastructure;

namespace FYPAPI.Test.Repositories
{
    public class FYPContextInitializer
    {
        public static IEnumerable<tblFypCategory> categories = new tblFypCategory[]{
            new tblFypCategory() { PK_tblFypCategories = "Artificial Intelligence" },
            new tblFypCategory() { PK_tblFypCategories = "Computer Games" },
            new tblFypCategory() { PK_tblFypCategories = "Computer Security" },
            new tblFypCategory() { PK_tblFypCategories = "Database" },
            new tblFypCategory() { PK_tblFypCategories = "Embedded Systems and Software" },
            new tblFypCategory() { PK_tblFypCategories = "Human Language Technology" },
            new tblFypCategory() { PK_tblFypCategories = "Miscellaneous" },
            new tblFypCategory() { PK_tblFypCategories = "Mobile and Wireless Computing" },
            new tblFypCategory() { PK_tblFypCategories = "Mobile Applications" },
            new tblFypCategory() { PK_tblFypCategories = "Mobile Gaming" },
            new tblFypCategory() { PK_tblFypCategories = "Networking" },
            new tblFypCategory() { PK_tblFypCategories = "Operating Systems" },
            new tblFypCategory() { PK_tblFypCategories = "Software Technology" },
            new tblFypCategory() { PK_tblFypCategories = "Theory" },
            new tblFypCategory() { PK_tblFypCategories = "Vision and Graphics" }
            };
        public static IEnumerable<tblFaculty> faculties = new tblFaculty[] {
            new tblFaculty("cafarella", "Michelle Cafarella", "3702", "MC"),
            new tblFaculty("fan", "Jim Fan", "3372", "JF"),
            new tblFaculty("garcia", "Holly Garcia", "3068", "HG"),
            new tblFaculty("hui", "Nancy Hui", "3556", "NH"),
            new tblFaculty("jag", "Hector Jag", "3923", "HJ"),
            new tblFaculty("larson", "Pauline Larson", "3588", "PL"),
            new tblFaculty("naughton", "Jack Naughton", "2628", "JN"),
            new tblFaculty("pantel", "Patty Pantel", "2345", "PP"),
            new tblFaculty("parames", "Agnes Parames", "3776", "AP"),
            new tblFaculty("ray", "Nelson Ray", "4178", "NR"),
            new tblFaculty("ruden", "Elke Ruden", "3158", "ER"),
            new tblFaculty("soliman", "Mary Soliman", "4116", "MS"),
            new tblFaculty("swart", "Gerry Swart", "3522", "GS"),
            new tblFaculty("thorn", "Martin Thorn", "3538", "MT"),
            new tblFaculty("lock", "Karl Lock", "3532", "KL"),
            new tblFaculty("zhang", "Vincent Zhang", "3408", "VZ")
        };
        public static IEnumerable<tblFyp> fyps = new tblFyp[]{
            new tblFyp(1, "Learn Golf Using Kinect", "Microsoft Kinect allows a person's skeletal movement to be tracked and to recognize the person's speech. In this FYP, you will write an app using a Kinect or two Kinects (which the department will provide to you) to teach golfing strokes. You are required to track the golfing movements of a learner, compare the learner's movements with those from a master golfer and give feedback to the learner so that he/she can correct his/her movements.", "Artificial Intelligence", "project", "C++/C#; algorithm design; creative mind", 1, 2, true),
            new tblFyp(2, "MOOC Data Analytics: Social Network Analysis of Discussion Forum Data", "Massive open online courses (MOOCs) on such online platforms as Coursera, edX, Khan Academy and Udacity are perceived by many people as reinventing education to a certain extent. A consequence of this recent trend is the availability of massive amounts of data from MOOCs for research in learning analytics and other areas. This FYP will make use of discussion forum data involving tens of thousands of students from several HKUST courses offered on Coursera. Some machine learning problems related to social network analysis will be studied.", "Artificial Intelligence", "thesis", "strong background in programming and mathematics; good background in mathematics is essential for learning the machine learning models; experience in programming on Linux/Unix platforms is a plus.", 1, 1, false),
            new tblFyp(3, "Android Mobile Action RPG Game", "In this FYP you will design and implement an adventure computer game. You should propose an interesting game scenario (i.e., the story). It can be anything and does not have to be an adventure game, but must be interesting/funny/surprising. Simple ideas are often the best � like StoneAge UST a few years ago. Also, you need to draw some pictures that show how your game will look (e.g., a few main characters, scenes � can be hand-drawn or computer-drawn). Someone in the group needs to have the artistic skills to make the game attractive. Designing a fun and interesting game scenario is an important part of the FYP, as is implementing it. It doesn't matter what software package is used to implement the game (Java, Flash, Visual Basic), but it needs to be fun and interesting to play and watch. It can be a 3D RPG game if you choose. An interesting 2D game is also okay (e.g., dragons and monsters in the library maze of stacks).", "Computer Games", "project", "creativity", 1, 4, true),
            new tblFyp(4, "Side-Scrolling Computer Game", "This category of game has been changing how people think about 'gaming' at least by defining a new way to 'play'. Besides the classics, there are some recent side-scrolling games which are also popular and successful, such as LIMBO. As we found this kind of game fun, we would like to develop our own side-scrolling game. In addition, you should also think about adding RPG like attributes/growth to the game.", "Computer Games", "project", "", 4, 4, false),
            new tblFyp(5, "Turn-Based Strategy Game", "The aim of this FYP is to create a Turn-Based Strategy Game (examples include Fire Emblem, Advanced Wars) in a fantasy universe. It will be a series of levels that should be randomly generated and valid maps, with plans to extend this to include a genetic algorithm that helps create levels.", "Computer Games", "project", "creativity", 1, 1, false),
            new tblFyp(6, "A Spatial-temporal Data Analytical System for Microblogs", "With the advances in GPS-equipped handheld devices, microblogs have entered a new era where time/location can be attached to each posted microblog. Consequently, it is possible to perform various kinds of analysis to find interesting pattern in the posts. Examples include:\n(1) What is the spatial distribution of microblogs posted between 8am and 9am in Hong Kong?\n(2) How does the above distribution changes if we set the time window to 8pm to 9pm?\n(3) At HKUST, what were the most popular keywords in the microblogs posted last month?\n(4) During last week, how many microblogs contain the keywords 'FYP'? How are they distributed in space?\nIn this FYP you will build a spatial-temporal data analytical system for microblogs.", "Database", "project", "programming; algorithm design; visualization", 3, 4, true),
            new tblFyp(7, "A Study of Social Network Analysis", "Data mining (or knowledge discovery) can find interesting patterns from past history. Websites like Facebook provide information about the relationships between individuals. With this information, we can select 'better' customers for promotions. This is because, if we promote the new product to an individual and he is satisfied about this new product, it is more likely that he will promote this new product to his friends. With this reasoning, the salesman will not need to promote to some of his friends and thus a lot of effort can be saved. In this FYP, we will study how to select some potential customers for marketing with the use of these websites.", "Database", "project", "good programming skills", 1, 1, true),
            new tblFyp(8, "Build a Personal Internet TVBox", "Build a personal, customizable Internet TV box using Raspberry PI.", "Embedded Systems and Software", "project", "good programming skills; Linux", 1, 3, true),
            new tblFyp(9, "Customizable Surround Sound with Raspberry Pi", "Using a raspberry Pi, the aim is to build a smart speaker that will allow different surround sound settings for the audio playback and direct the channels to the speakers accordingly.", "Embedded Systems and Software", "project", "", 1, 1, true),
            new tblFyp(10, "Radically New Intelligent Controllers / User Interfaces for Electronic Music", "Much of electronic music has focused on the generation and synthesis of sound, but to a real musician, what is even more important is being able to control the sound in highly expressive ways. Hardware controllers have been built to mimic the user interfaces of traditional acoustic instruments like pianos, guitars, drums, wind instruments and string instruments. However, new types of controllers such as multitouch screens, accelerometers, Kinect, etc. offer a far richer set of possibilities for NON-TRADITIONAL expressive control over electronic instruments. In this FYP, you will develop new AI-assisted methods that exploit these new technologies to offer musicians radically new real-time user interfaces.", "Human Language Technology", "project", "strong skills in one or more of the following: programming, linguistics, and/or mathematics", 1, 4, true),
            new tblFyp(11, "Machine Learning of Chinese and English", "This FYT aims to build and experiment with models that use machine learning and pattern recognition techniques to automatically learn human languages, specifically Chinese and English. On the one hand, this FYP gives excellent international exposure to practical state-of-the-art engineering techniques for machine learning, data mining and intelligent language processing technologies. On the other hand, this FYP also provides a solid introduction to one of the grand challenges of science: how the human mind works.", "Human Language Technology", "thesis", "strong skills in one or more of the following: programming, linguistics, and/or mathematics", 1, 1, true),
            new tblFyp(12, "Dynamic Road Networks", "Road networks are represented by directed graphs where the nodes and the edges correspond to road intersections and road segments, respectively. Dynamic road networks (DRNs) capture accurately the traffic in a road network by assigning time-dependent weights on the edges, according to the time of traversal. For instance, a vehicle might take 20 minutes to traverse a road segment in Mongkok at 10:00am (peak hour), whereas at 11:00pm (low congestion) it could take only 5 minutes. Due to the severe effect of traffic, the fastest path between two points in a DRN depends heavily on the trip time. In this final year FYP, you will extend known shortest-path and related methods in order to efficiently compute fastest paths in DRNs.", "Miscellaneous", "project", "programming skills; C++; algorithm design", 1, 4, true),
            new tblFyp(13, "Social Distance Computation", "Nowadays, the analysis of social networks is essential for numerous marketing and advertisement purposes. A major analytic tool is the computation of the social distance between two users of the social network. The social distance measures how socially close two individuals are to one another. The goal of this final year FYP is to implement and experimentally evaluate the existing methods on social distance computation.", "Miscellaneous", "project", "familiar with the C++ programming language and the Linux operating system", 1, 4, true),
            new tblFyp(14, "Music Emotion and Timbre", "Music is one of the strongest triggers of emotions. Melody, rhythm and harmony are important triggers, but what about timbre? Though music emotion recognition has received a lot of attention, researchers have only recently begun considering the relationship between emotion and timbre. Our group's research has shown that musical instruments have an emotional predisposition for sustaining instruments and decaying instruments (e.g., the melancholy sound of the English horn). We have tested eight emotions and found strong emotional predispositions for each instrument. The emotions Happy, Joyful, Heroic and Comic were strongly correlated with one another and the violin, trumpet and clarinet best evoked these emotions. Sad and Depressed were also strongly correlated, and were best evoked by the horn and flute. Scary was an emotional outlier and the oboe had an emotionally neutral disposition. For this FYT you will follow up the above work. You will consider either the emotional dispositions of other instruments or you might consider the effect of algorithms such as MP3 compression on musical emotion and timbre or you can propose you own idea for music emotion and timbre.", "Miscellaneous", "thesis", "COMP4441; deep desire to combine music and CS; good ear for music and musical timbres; reasonably strong statistics background", 1, 1, true),
            new tblFyp(15, "Emotion Sensing Using Smartphones", "Affective computing tries to assign computers the human-like capabilities of observation, interpretation and generation of affect features. Nowadays, thanks to powerful smart devices, abundant sensors are available in our daily life that make it possible to collect information for affect detection (e.g., sound, facial expression, touch gesture, human movement, etc.). Consequently, it is possible not only to track real emotions, but also to significantly improve the accuracy of affect detection. In this FYP, you will develop a framework on a smartphone that understands user emotions and produces positive responses for help.", "Mobile and Wireless Computing", "project", "solid programming skill in Java or C++; experience in Android development", 1, 1, true),
            new tblFyp(16, "Price Sharing Application", "Supermarkets or chain stores in Hong Kong are always changing the retail price of their items in unpredictable ways. Consumers may want to know if a certain promotion really brings tangible benefits to them. In this FYP you will construct a database of the price for all the goods in the market. First you will develop an app for consumers to share the price of the items they bought. They only need to use the camera to record the barcode and input the price manually. Through the same app, people can view the price history of a certain item when they are shopping.", "Mobile and Wireless Computing", "project", "Android programming; database; operating system", 2, 3, true),
            new tblFyp(17, "Ride-sharing Mobile Application", "Ride-sharing is a green initiative from the HKUST sustainability unit. The FYP involves creating mobile application support for ride sharing and server support for the program.", "Mobile Applications", "project", "HTML5; Javascript; JQuery mobile", 2, 4, true),
            new tblFyp(18, "Context-Aware War Game with Motion and Gesture Recognition", "This FYP will develop a location-based, Android war game which allows players to interact with movements, gestures and NFC technologies. Players will be able to catch Pok�mons and play games with each other. The scenes can be sensitive to time, weather and locations.", "Mobile Gaming", "project", "Android; database; sensor programming; NFC; game design", 1, 4, true),
            new tblFyp(19, "Puzzle and Action RPG Game for Mobile Devices", "The most popular mobile game type nowadays is a puzzle game like Candy Crush Saga, targeted at people of all ages, and Puzzle and Dragons targeted at teenagers. We can see that the attractive point of these games is the puzzle solving system and the amazing combo moment. In addition, some types of games have already been popular for at least two decades. The representatives of this type of game are action RPG games. Combining these attractive elements, you will develop a Puzzle + Action RPG Game.", "Mobile Gaming", "project", "programming; mobile computing", 2, 2, true),
            new tblFyp(20, "Time-travel on the Internet", "In this FYP, students will develop an Internet archiving system to crawl the Internet similar to a search engine. Moreover, the system will store numerous copies of the web pages as the pages evolve over time. With this dynamically growing archive, users can 'time travel' in the archive and search information that cannot be provided by existing search engines. After completing this FYP, the students will have good understanding of Internet technology and will have acquired skills for developing advanced user-oriented network systems.", "Networking", "project", "C/C++ programming; web programming; ability to use UNIX/Linux", 1, 4, true),
            new tblFyp(21, "Wi-Fi Channel Optimizer for Android", "This is a Wi-Fi FYP to implement an Android app which finds the optimal Wi-Fi channel when deploying a wireless router at home or office. An AP can usually automatically assign a least congested channel based on the startup scan result. Such a scan result reflects the environment in which the AP is located. However, this channel may not be the best channel for the users in different locations, such as in the bedroom with totally different interference characteristics. Therefore, it is better to also scan the interference at the user location. This app scans the wireless networks at multiple positions, analyzes the scan results with channel selection algorithms and suggests the best channel for the network.", "Networking", "project", "Java; general Wi-Fi knowledge; Android SDK", 1, 4, true),
            new tblFyp(22, "Optimizing Compiler for Distributed Computing", "Compiler optimization requires a tremendous amount of understanding in the high-level language and the underlying computer abstraction. It is more challenging to develop an optimizing compiler for a distributed platform. In this FYP, the student will design and implement optimization schemes for the C0 compiler, generate code for the i0 architecture and measure the improvement on the CCMR cloud computing test bed.", "Operating Systems", "project", "", 1, 1, true),
            new tblFyp(23, "An Interactive Environment for Learning Computer Programming", "This FYP aims to develop an interactive environment for learning computer programming. It should be a Web-based environment with a collection of interactive tools. These tools allow students to easily and effectively self-learn computer programming skills.", "Software Technology", "project", "Internet programming", 1, 1, true),
            new tblFyp(24, "HKUST Class Radar", "From time to time, instructors would like to invite students to answer questions in class. The aim of this FYP is to develop a mobile app displaying a radar of students attending the class. This will facilitate the instructor to invite a particular student (especially those sitting at the back) to answer class questions. Instructors may preload their course enrollment and classroom configuration. The app also enables students to team up for class discussion in blended learning lectures.", "Software Technology", "project", "COMP3111; Java; Android", 1, 4, true),
            new tblFyp(25, "Predicting What People Will Talk About Tomorrow", "This FYP aims to develop a system, either browser based or app based, to predict what people will talk about on social networks (e.g., Twitter). What the system should predict includes, but is not limit to: (i) what would they be talking about tomorrow, or the day after tomorrow, etc. and (ii) if they do talk about a topic, for how long and at what intensity (e.g., in terms of number of messages posted per hour). The method on hand is to extract the topics that people have talked about in the past, analyze their characteristics (e.g., are these just short-term interests that will die down very soon or they are hot topics that will last for a couple of weeks or they will recur periodically, like world soccer cup, every four years). Therefore, before you leave home, you can take a look at the screen and be 'prepared' for what to talk about when you see your friends.", "Software Technology", "project", "algorithm design; Java; interest in doing research", 2, 4, true),
            new tblFyp(26, "Real-world Application Development", "In this FYP your group will develop software (e.g., a website, an app, etc.) for a real company using software engineering and database management technology. You will have to find a suitable company that will allow you to carry out the FYP. Examples of possible applications might be managing customer records, managing inventory, tracking orders and sales, managing the membership of an organization, scheduling items for shipment or delivery, providing web access (either to the public or to other companies) to a database of the items that a company sells. This FYP will give you an opportunity to apply and integrate things you have learned in various courses to a real-world problem.", "Software Technology", "project", "COMP3111 or COMP 3111H; COMP 3311; willing to work with users in a company", 1, 4, true),
            new tblFyp(27, "Many-core Parallel Computing", "Commodity processors have become parallel computing platforms involving hundreds of cores. This FYT will study the state of the art in many-core parallel computing and pick a smaller topic for further investigation.", "Software Technology", "thesis", "fast learner", 1, 1, true),
            new tblFyp(28, "Streaming Algorithms", "For this FYT on streaming algorithms, the student should have strong skills in algorithm design and implementation, as well as mathematics.", "Theory", "thesis", "COMP3711 or COMP3711H; algorithm design; programming; mathematics", 1, 1, true),
            new tblFyp(29, "3D City Reconstruction from Images", "This FYP will investigate a methodology for the large-scale 3D reconstruction of cities from ground-level images. The goal is to produce detailed geometry and appearance that is well-suited for displaying as 'street views'. The FYP will provide key components for platforms dedicated to emerging 3D maps and digital city applications, greatly improving the current representation based on 2D panoramas.", "Vision and Graphics", "project", "C++ programming skills", 1, 4, true),
            new tblFyp(30, "Photo Repairing", "Inpainting is originally a technique commonly used by conservators to unify a painting that has suffered paint loss. This FYP aims at analyzing various inpainting techniques and developing a real-world application for photo repairing (e.g., fixing damaged photos).", "Vision and Graphics", "project", "some background in mathematics and good programming skills.", 2, 3, false)
        };
        public static IEnumerable<tblProjectGroup> groups = new tblProjectGroup[]{
            new tblProjectGroup() { groupCode = "MC1", assignedFYP = 2, reader = "ray", PK_tblProjectGroups = 1 },
            new tblProjectGroup() { groupCode = "MC2", assignedFYP = 11, reader = "ray", PK_tblProjectGroups = 2 },
            new tblProjectGroup() { groupCode = "JNHJ1", assignedFYP = 5, PK_tblProjectGroups = 3 },
            new tblProjectGroup() { groupCode = "JNHJ2", assignedFYP = 5, reader = "cafarella", PK_tblProjectGroups = 4 },
            new tblProjectGroup() { groupCode = "JNHJ3", assignedFYP = 5, PK_tblProjectGroups = 5 },
            new tblProjectGroup() { groupCode = "HJ1", assignedFYP = 26, reader = "ruden", PK_tblProjectGroups = 6 },
            new tblProjectGroup() { groupCode = "JF1", assignedFYP = 30, reader = "naughton", PK_tblProjectGroups = 7 },
            new tblProjectGroup() { groupCode = "JN1", assignedFYP = 4, reader = "fan", PK_tblProjectGroups = 8 },
            new tblProjectGroup() { groupCode = "NH1", assignedFYP = 13, reader = "naughton", PK_tblProjectGroups = 9 },
            new tblProjectGroup(10, null, null, null),
            new tblProjectGroup(11, null, null, null),
            new tblProjectGroup(12, null, null, null),
            new tblProjectGroup(13, null, null, null),
            new tblProjectGroup(14, null, null, null),
            new tblProjectGroup(15, null, null, null),
            new tblProjectGroup(16, null, null, null)
        };
        public static IEnumerable<tblSupervis> supervises = new tblSupervis[] {
            new tblSupervis("cafarella", 1),
            new tblSupervis("cafarella", 2),
            new tblSupervis("cafarella", 11),
            new tblSupervis("cafarella", 12),
            new tblSupervis("fan", 29),
            new tblSupervis("fan", 30),
            new tblSupervis("garcia", 17),
            new tblSupervis("garcia", 18),
            new tblSupervis("garcia", 23),
            new tblSupervis("hui", 13),
            new tblSupervis("hui", 22),
            new tblSupervis("jag", 5),
            new tblSupervis("jag", 6),
            new tblSupervis("jag", 7),
            new tblSupervis("jag", 8),
            new tblSupervis("jag", 9),
            new tblSupervis("jag", 24),
            new tblSupervis("jag", 26),
            new tblSupervis("naughton", 3),
            new tblSupervis("naughton", 4),
            new tblSupervis("naughton", 5),
            new tblSupervis("naughton", 7),
            new tblSupervis("naughton", 19),
            new tblSupervis("pantel", 8),
            new tblSupervis("pantel", 9),
            new tblSupervis("pantel", 12),
            new tblSupervis("pantel", 13),
            new tblSupervis("pantel", 21),
            new tblSupervis("parames", 15),
            new tblSupervis("parames", 16),
            new tblSupervis("parames", 18),
            new tblSupervis("parames", 20),
            new tblSupervis("ray", 10),
            new tblSupervis("ruden", 14),
            new tblSupervis("ruden", 28),
            new tblSupervis("soliman", 21),
            new tblSupervis("soliman", 25),
            new tblSupervis("soliman", 27)
        };
        public static IEnumerable<tblRequirementGrade> grades = new tblRequirementGrade[] {
            new tblRequirementGrade("naughton", "lesterlo", 66, 72, 75, 80),
            new tblRequirementGrade("cafarella", "lesterlo", 66, 72, 75, 80),
            new tblRequirementGrade("hui", "terrytam", 75, 67, 72, 77),
            new tblRequirementGrade("naughton", "terrytam", 70, 65, 75, 80)
        };
        public static IEnumerable<tblCSEStudent> studs = new tblCSEStudent[] {
            new tblCSEStudent("brunoho"     , "Bruno Ho"    , 1) { etag = "20121231210032"},
            new tblCSEStudent("daisyyeung"  , "Daisy Yeung" , 2),
            new tblCSEStudent("adamau"      , "Adam Au"     , 3),
            new tblCSEStudent("lesterlo"    , "Lester Lo"   , 4),
            new tblCSEStudent("shirleysit"  , "Shirley Sit" , 5),
            new tblCSEStudent("frankfung"   , "Frank Fung"  , 6),
            new tblCSEStudent("larrylai"    , "Larry Lai"   , 6),
            new tblCSEStudent("fredfan"     , "Fred Fan"    , 7),
            new tblCSEStudent("jennyjones"  , "Jenny Jones" , 7),
            new tblCSEStudent("timothytu"   , "Timothy Tu"  , 7),
            new tblCSEStudent("brianma"     , "Brian Ma"    , 8),
            new tblCSEStudent("kathyko"     , "Kathy Ko"    , 8),
            new tblCSEStudent("monicama"    , "Monica Ma"   , 8),
            new tblCSEStudent("susansze"    , "Susan Sze"   , 8),
            new tblCSEStudent("terrytam"    , "Terry Tam"   , 9),
            new tblCSEStudent("sharonsu"    , "Sharon Su"   , 10),
            new tblCSEStudent("wendywong"   , "Wendy Wong"  , 11),
            new tblCSEStudent("ireneip"     , "Irene Ip"    , 12),
            new tblCSEStudent("peterpoon"   , "Peter Poon"  , 12),
            new tblCSEStudent("tiffanytan"  , "Tiffany Tan" , 13),
            new tblCSEStudent("victoriayu"  , "Victoria Yu" , 13),
            new tblCSEStudent("dannydoan"   , "Danny Doan"  , 13),
            new tblCSEStudent("carolchen"   , "Carol Chen"  , 14),
            new tblCSEStudent("cindychan"   , "Cindy Chan"  , 14),
            new tblCSEStudent("tracytse"    , "Tracy Tse"   , 14),
            new tblCSEStudent("yvonneyu"    , "Yvonne Yu"   , 14),
            new tblCSEStudent("clintchu"    , "Clint Chu"   , 15),
            new tblCSEStudent("amandahui"   , "Amanda Hui"  , 15),
            new tblCSEStudent("henryho"     , "Henry Ho"    , 16),
            new tblCSEStudent("tonytong"    , "Tony Tong"   , 16),
            new tblCSEStudent("walterwu"    , "Walter Wu"   , 16),
            new tblCSEStudent("xavierxie"   , "Xavier Xie"  , 16),
            new tblCSEStudent("steviesu"    , "Stevie Su"   , null),
            new tblCSEStudent("rezanlim"    , "Rezan Lim"   , null),
            new tblCSEStudent("bradybond"   , "Brady Bond"  , null),
            new tblCSEStudent("vivianso"    , "Vivian So"   , null),
            new tblCSEStudent("alanseto"    , "Alan Seto"   , null),
            new tblCSEStudent("lucylam"     , "Lucy Lam"    , null),
            new tblCSEStudent("hughhawes"   , "Hugh Hawes"  , null),
            new tblCSEStudent("carlchan"    , "Carl Chan"   , null)
        };
        public static IEnumerable<tblInterestedIn> interests = new tblInterestedIn[]{
            new tblInterestedIn(1, 6, 1),
            new tblInterestedIn(1, 11, 1),
            new tblInterestedIn(2, 1, 2),
            new tblInterestedIn(2, 2, 1),
            new tblInterestedIn(2, 3, 1),
            new tblInterestedIn(3, 3, 5),
            new tblInterestedIn(3, 10, 2),
            new tblInterestedIn(4, 8, 1),
            new tblInterestedIn(5, 3, 4),
            new tblInterestedIn(5, 4, 1),
            new tblInterestedIn(5, 5, 1),
            new tblInterestedIn(5, 11, 2),
            new tblInterestedIn(7, 9, 3),
            new tblInterestedIn(8, 12, 1),
            new tblInterestedIn(8, 7, 3),
            new tblInterestedIn(10, 8, 3),
            new tblInterestedIn(10, 14, 3),
            new tblInterestedIn(11, 1, 1),
            new tblInterestedIn(11, 2, 2),
            new tblInterestedIn(11, 3, 3),
            new tblInterestedIn(12, 7, 2),
            new tblInterestedIn(13, 9, 5),
            new tblInterestedIn(16, 12, 2),
            new tblInterestedIn(16, 13, 1),
            new tblInterestedIn(17, 14, 4),
            new tblInterestedIn(18, 3, 3),
            new tblInterestedIn(18, 5, 2),
            new tblInterestedIn(18, 10, 1),
            new tblInterestedIn(18, 7, 4),
            new tblInterestedIn(19, 12, 3),
            new tblInterestedIn(20, 10, 3),
            new tblInterestedIn(20, 12, 4),
            new tblInterestedIn(20, 13, 2),
            new tblInterestedIn(21, 14, 2),
            new tblInterestedIn(23, 9, 1),
            new tblInterestedIn(24, 8, 2),
            new tblInterestedIn(25, 12, 5),
            new tblInterestedIn(26, 6, 1),
            new tblInterestedIn(26, 10, 1),
            new tblInterestedIn(26, 14, 1),
            new tblInterestedIn(29, 8, 4),
            new tblInterestedIn(30, 6, 2),
            new tblInterestedIn(30, 7, 1)
        };
        public static void ContextInit(FYPContext context) {
            context.tblFypCategories.AddRange(categories);
            context.tblFaculties.AddRange(faculties);
            context.tblFyps.AddRange(fyps);
            context.tblProjectGroups.AddRange(groups);
            context.tblSupervises.AddRange(supervises);
            context.tblRequirementGrades.AddRange(grades);
            context.tblCSEStudents.AddRange(studs);
            context.tblInterestedIns.AddRange(interests);

            // Initialize FYPCategories
            // Initialize Faculties
            // Initialize FYP
            //Initialize ProjectGroups
            //Initialize Supervises
            //Initialize RequirementGrades
            //Initialize CSEStudents
            //Initialize InterestedIns
            /*context.tblFypCategories.Add(new tblFypCategory() { PK_tblFypCategories = "Artificial Intelligence" });
            context.tblFypCategories.Add(new tblFypCategory() { PK_tblFypCategories = "Computer Games" });
            context.tblFypCategories.Add(new tblFypCategory() { PK_tblFypCategories = "Computer Security" });
            context.tblFypCategories.Add(new tblFypCategory() { PK_tblFypCategories = "Database" });
            context.tblFypCategories.Add(new tblFypCategory() { PK_tblFypCategories = "Embedded Systems and Software" });
            context.tblFypCategories.Add(new tblFypCategory() { PK_tblFypCategories = "Human Language Technology" });
            context.tblFypCategories.Add(new tblFypCategory() { PK_tblFypCategories = "Miscellaneous" });
            context.tblFypCategories.Add(new tblFypCategory() { PK_tblFypCategories = "Mobile and Wireless Computing" });
            context.tblFypCategories.Add(new tblFypCategory() { PK_tblFypCategories = "Mobile Applications" });
            context.tblFypCategories.Add(new tblFypCategory() { PK_tblFypCategories = "Mobile Gaming" });
            context.tblFypCategories.Add(new tblFypCategory() { PK_tblFypCategories = "Networking" });
            context.tblFypCategories.Add(new tblFypCategory() { PK_tblFypCategories = "Operating Systems" });
            context.tblFypCategories.Add(new tblFypCategory() { PK_tblFypCategories = "Software Technology" });
            context.tblFypCategories.Add(new tblFypCategory() { PK_tblFypCategories = "Theory" });
            context.tblFypCategories.Add(new tblFypCategory() { PK_tblFypCategories = "Vision and Graphics" });

            context.tblFaculties.Add(new tblFaculty("cafarella", "Michelle Cafarella", "3702", "MC"));
            context.tblFaculties.Add(new tblFaculty("fan", "Jim Fan", "3372", "JF"));
            context.tblFaculties.Add(new tblFaculty("garcia", "Holly Garcia", "3068", "HG"));
            context.tblFaculties.Add(new tblFaculty("hui", "Nancy Hui", "3556", "NH"));
            context.tblFaculties.Add(new tblFaculty("jag", "Hector Jag", "3923", "HJ"));
            context.tblFaculties.Add(new tblFaculty("larson", "Pauline Larson", "3588", "PL"));
            context.tblFaculties.Add(new tblFaculty("naughton", "Jack Naughton", "2628", "JN"));
            context.tblFaculties.Add(new tblFaculty("pantel", "Patty Pantel", "2345", "PP"));
            context.tblFaculties.Add(new tblFaculty("parames", "Agnes Parames", "3776", "AP"));
            context.tblFaculties.Add(new tblFaculty("ray", "Nelson Ray", "4178", "NR"));
            context.tblFaculties.Add(new tblFaculty("ruden", "Elke Ruden", "3158", "ER"));
            context.tblFaculties.Add(new tblFaculty("soliman", "Mary Soliman", "4116", "MS"));
            context.tblFaculties.Add(new tblFaculty("swart", "Gerry Swart", "3522", "GS"));
            context.tblFaculties.Add(new tblFaculty("thorn", "Martin Thorn", "3538", "MT"));
            context.tblFaculties.Add(new tblFaculty("lock", "Karl Lock", "3532", "KL"));
            context.tblFaculties.Add(new tblFaculty("zhang", "Vincent Zhang", "3408", "VZ"));

            context.tblFyps.Add(new tblFyp(1, "Learn Golf Using Kinect", "Microsoft Kinect allows a person's skeletal movement to be tracked and to recognize the person's speech. In this FYP, you will write an app using a Kinect or two Kinects (which the department will provide to you) to teach golfing strokes. You are required to track the golfing movements of a learner, compare the learner's movements with those from a master golfer and give feedback to the learner so that he/she can correct his/her movements.", "Artificial Intelligence", "project", "C++/C#; algorithm design; creative mind", 1, 2, true));
            context.tblFyps.Add(new tblFyp(2, "MOOC Data Analytics: Social Network Analysis of Discussion Forum Data", "Massive open online courses (MOOCs) on such online platforms as Coursera, edX, Khan Academy and Udacity are perceived by many people as reinventing education to a certain extent. A consequence of this recent trend is the availability of massive amounts of data from MOOCs for research in learning analytics and other areas. This FYP will make use of discussion forum data involving tens of thousands of students from several HKUST courses offered on Coursera. Some machine learning problems related to social network analysis will be studied.", "Artificial Intelligence", "thesis", "strong background in programming and mathematics; good background in mathematics is essential for learning the machine learning models; experience in programming on Linux/Unix platforms is a plus.", 1, 1, false));
            context.tblFyps.Add(new tblFyp(3, "Android Mobile Action RPG Game", "In this FYP you will design and implement an adventure computer game. You should propose an interesting game scenario (i.e., the story). It can be anything and does not have to be an adventure game, but must be interesting/funny/surprising. Simple ideas are often the best � like StoneAge UST a few years ago. Also, you need to draw some pictures that show how your game will look (e.g., a few main characters, scenes � can be hand-drawn or computer-drawn). Someone in the group needs to have the artistic skills to make the game attractive. Designing a fun and interesting game scenario is an important part of the FYP, as is implementing it. It doesn't matter what software package is used to implement the game (Java, Flash, Visual Basic), but it needs to be fun and interesting to play and watch. It can be a 3D RPG game if you choose. An interesting 2D game is also okay (e.g., dragons and monsters in the library maze of stacks).", "Computer Games", "project", "creativity", 1, 4, true));
            context.tblFyps.Add(new tblFyp(4, "Side-Scrolling Computer Game", "This category of game has been changing how people think about 'gaming' at least by defining a new way to 'play'. Besides the classics, there are some recent side-scrolling games which are also popular and successful, such as LIMBO. As we found this kind of game fun, we would like to develop our own side-scrolling game. In addition, you should also think about adding RPG like attributes/growth to the game.", "Computer Games", "project", "", 4, 4, false));
            context.tblFyps.Add(new tblFyp(5, "Turn-Based Strategy Game", "The aim of this FYP is to create a Turn-Based Strategy Game (examples include Fire Emblem, Advanced Wars) in a fantasy universe. It will be a series of levels that should be randomly generated and valid maps, with plans to extend this to include a genetic algorithm that helps create levels.", "Computer Games", "project", "creativity", 1, 1, false));
            context.tblFyps.Add(new tblFyp(6, "A Spatial-temporal Data Analytical System for Microblogs", "With the advances in GPS-equipped handheld devices, microblogs have entered a new era where time/location can be attached to each posted microblog. Consequently, it is possible to perform various kinds of analysis to find interesting pattern in the posts. Examples include:\n(1) What is the spatial distribution of microblogs posted between 8am and 9am in Hong Kong?\n(2) How does the above distribution changes if we set the time window to 8pm to 9pm?\n(3) At HKUST, what were the most popular keywords in the microblogs posted last month?\n(4) During last week, how many microblogs contain the keywords 'FYP'? How are they distributed in space?\nIn this FYP you will build a spatial-temporal data analytical system for microblogs.", "Database", "project", "programming; algorithm design; visualization", 3, 4, true));
            context.tblFyps.Add(new tblFyp(7, "A Study of Social Network Analysis", "Data mining (or knowledge discovery) can find interesting patterns from past history. Websites like Facebook provide information about the relationships between individuals. With this information, we can select 'better' customers for promotions. This is because, if we promote the new product to an individual and he is satisfied about this new product, it is more likely that he will promote this new product to his friends. With this reasoning, the salesman will not need to promote to some of his friends and thus a lot of effort can be saved. In this FYP, we will study how to select some potential customers for marketing with the use of these websites.", "Database", "project", "good programming skills", 1, 1, true));
            context.tblFyps.Add(new tblFyp(8, "Build a Personal Internet TVBox", "Build a personal, customizable Internet TV box using Raspberry PI.", "Embedded Systems and Software", "project", "good programming skills; Linux", 1, 3, true));
            context.tblFyps.Add(new tblFyp(9, "Customizable Surround Sound with Raspberry Pi", "Using a raspberry Pi, the aim is to build a smart speaker that will allow different surround sound settings for the audio playback and direct the channels to the speakers accordingly.", "Embedded Systems and Software", "project", "", 1, 1, true));
            context.tblFyps.Add(new tblFyp(10, "Radically New Intelligent Controllers / User Interfaces for Electronic Music", "Much of electronic music has focused on the generation and synthesis of sound, but to a real musician, what is even more important is being able to control the sound in highly expressive ways. Hardware controllers have been built to mimic the user interfaces of traditional acoustic instruments like pianos, guitars, drums, wind instruments and string instruments. However, new types of controllers such as multitouch screens, accelerometers, Kinect, etc. offer a far richer set of possibilities for NON-TRADITIONAL expressive control over electronic instruments. In this FYP, you will develop new AI-assisted methods that exploit these new technologies to offer musicians radically new real-time user interfaces.", "Human Language Technology", "project", "strong skills in one or more of the following: programming, linguistics, and/or mathematics", 1, 4, true));
            context.tblFyps.Add(new tblFyp(11, "Machine Learning of Chinese and English", "This FYT aims to build and experiment with models that use machine learning and pattern recognition techniques to automatically learn human languages, specifically Chinese and English. On the one hand, this FYP gives excellent international exposure to practical state-of-the-art engineering techniques for machine learning, data mining and intelligent language processing technologies. On the other hand, this FYP also provides a solid introduction to one of the grand challenges of science: how the human mind works.", "Human Language Technology", "thesis", "strong skills in one or more of the following: programming, linguistics, and/or mathematics", 1, 1, true));
            context.tblFyps.Add(new tblFyp(12, "Dynamic Road Networks", "Road networks are represented by directed graphs where the nodes and the edges correspond to road intersections and road segments, respectively. Dynamic road networks (DRNs) capture accurately the traffic in a road network by assigning time-dependent weights on the edges, according to the time of traversal. For instance, a vehicle might take 20 minutes to traverse a road segment in Mongkok at 10:00am (peak hour), whereas at 11:00pm (low congestion) it could take only 5 minutes. Due to the severe effect of traffic, the fastest path between two points in a DRN depends heavily on the trip time. In this final year FYP, you will extend known shortest-path and related methods in order to efficiently compute fastest paths in DRNs.", "Miscellaneous", "project", "programming skills; C++; algorithm design", 1, 4, true));
            context.tblFyps.Add(new tblFyp(13, "Social Distance Computation", "Nowadays, the analysis of social networks is essential for numerous marketing and advertisement purposes. A major analytic tool is the computation of the social distance between two users of the social network. The social distance measures how socially close two individuals are to one another. The goal of this final year FYP is to implement and experimentally evaluate the existing methods on social distance computation.", "Miscellaneous", "project", "familiar with the C++ programming language and the Linux operating system", 1, 4, true));
            context.tblFyps.Add(new tblFyp(14, "Music Emotion and Timbre", "Music is one of the strongest triggers of emotions. Melody, rhythm and harmony are important triggers, but what about timbre? Though music emotion recognition has received a lot of attention, researchers have only recently begun considering the relationship between emotion and timbre. Our group's research has shown that musical instruments have an emotional predisposition for sustaining instruments and decaying instruments (e.g., the melancholy sound of the English horn). We have tested eight emotions and found strong emotional predispositions for each instrument. The emotions Happy, Joyful, Heroic and Comic were strongly correlated with one another and the violin, trumpet and clarinet best evoked these emotions. Sad and Depressed were also strongly correlated, and were best evoked by the horn and flute. Scary was an emotional outlier and the oboe had an emotionally neutral disposition. For this FYT you will follow up the above work. You will consider either the emotional dispositions of other instruments or you might consider the effect of algorithms such as MP3 compression on musical emotion and timbre or you can propose you own idea for music emotion and timbre.", "Miscellaneous", "thesis", "COMP4441; deep desire to combine music and CS; good ear for music and musical timbres; reasonably strong statistics background", 1, 1, true));
            context.tblFyps.Add(new tblFyp(15, "Emotion Sensing Using Smartphones", "Affective computing tries to assign computers the human-like capabilities of observation, interpretation and generation of affect features. Nowadays, thanks to powerful smart devices, abundant sensors are available in our daily life that make it possible to collect information for affect detection (e.g., sound, facial expression, touch gesture, human movement, etc.). Consequently, it is possible not only to track real emotions, but also to significantly improve the accuracy of affect detection. In this FYP, you will develop a framework on a smartphone that understands user emotions and produces positive responses for help.", "Mobile and Wireless Computing", "project", "solid programming skill in Java or C++; experience in Android development", 1, 1, true));
            context.tblFyps.Add(new tblFyp(16, "Price Sharing Application", "Supermarkets or chain stores in Hong Kong are always changing the retail price of their items in unpredictable ways. Consumers may want to know if a certain promotion really brings tangible benefits to them. In this FYP you will construct a database of the price for all the goods in the market. First you will develop an app for consumers to share the price of the items they bought. They only need to use the camera to record the barcode and input the price manually. Through the same app, people can view the price history of a certain item when they are shopping.", "Mobile and Wireless Computing", "project", "Android programming; database; operating system", 2, 3, true));
            context.tblFyps.Add(new tblFyp(17, "Ride-sharing Mobile Application", "Ride-sharing is a green initiative from the HKUST sustainability unit. The FYP involves creating mobile application support for ride sharing and server support for the program.", "Mobile Applications", "project", "HTML5; Javascript; JQuery mobile", 2, 4, true));
            context.tblFyps.Add(new tblFyp(18, "Context-Aware War Game with Motion and Gesture Recognition", "This FYP will develop a location-based, Android war game which allows players to interact with movements, gestures and NFC technologies. Players will be able to catch Pok�mons and play games with each other. The scenes can be sensitive to time, weather and locations.", "Mobile Gaming", "project", "Android; database; sensor programming; NFC; game design", 1, 4, true));
            context.tblFyps.Add(new tblFyp(19, "Puzzle and Action RPG Game for Mobile Devices", "The most popular mobile game type nowadays is a puzzle game like Candy Crush Saga, targeted at people of all ages, and Puzzle and Dragons targeted at teenagers. We can see that the attractive point of these games is the puzzle solving system and the amazing combo moment. In addition, some types of games have already been popular for at least two decades. The representatives of this type of game are action RPG games. Combining these attractive elements, you will develop a Puzzle + Action RPG Game.", "Mobile Gaming", "project", "programming; mobile computing", 2, 2, true));
            context.tblFyps.Add(new tblFyp(20, "Time-travel on the Internet", "In this FYP, students will develop an Internet archiving system to crawl the Internet similar to a search engine. Moreover, the system will store numerous copies of the web pages as the pages evolve over time. With this dynamically growing archive, users can 'time travel' in the archive and search information that cannot be provided by existing search engines. After completing this FYP, the students will have good understanding of Internet technology and will have acquired skills for developing advanced user-oriented network systems.", "Networking", "project", "C/C++ programming; web programming; ability to use UNIX/Linux", 1, 4, true));
            context.tblFyps.Add(new tblFyp(21, "Wi-Fi Channel Optimizer for Android", "This is a Wi-Fi FYP to implement an Android app which finds the optimal Wi-Fi channel when deploying a wireless router at home or office. An AP can usually automatically assign a least congested channel based on the startup scan result. Such a scan result reflects the environment in which the AP is located. However, this channel may not be the best channel for the users in different locations, such as in the bedroom with totally different interference characteristics. Therefore, it is better to also scan the interference at the user location. This app scans the wireless networks at multiple positions, analyzes the scan results with channel selection algorithms and suggests the best channel for the network.", "Networking", "project", "Java; general Wi-Fi knowledge; Android SDK", 1, 4, true));
            context.tblFyps.Add(new tblFyp(22, "Optimizing Compiler for Distributed Computing", "Compiler optimization requires a tremendous amount of understanding in the high-level language and the underlying computer abstraction. It is more challenging to develop an optimizing compiler for a distributed platform. In this FYP, the student will design and implement optimization schemes for the C0 compiler, generate code for the i0 architecture and measure the improvement on the CCMR cloud computing test bed.", "Operating Systems", "project", "", 1, 1, true));
            context.tblFyps.Add(new tblFyp(23, "An Interactive Environment for Learning Computer Programming", "This FYP aims to develop an interactive environment for learning computer programming. It should be a Web-based environment with a collection of interactive tools. These tools allow students to easily and effectively self-learn computer programming skills.", "Software Technology", "project", "Internet programming", 1, 1, true));
            context.tblFyps.Add(new tblFyp(24, "HKUST Class Radar", "From time to time, instructors would like to invite students to answer questions in class. The aim of this FYP is to develop a mobile app displaying a radar of students attending the class. This will facilitate the instructor to invite a particular student (especially those sitting at the back) to answer class questions. Instructors may preload their course enrollment and classroom configuration. The app also enables students to team up for class discussion in blended learning lectures.", "Software Technology", "project", "COMP3111; Java; Android", 1, 4, true));
            context.tblFyps.Add(new tblFyp(25, "Predicting What People Will Talk About Tomorrow", "This FYP aims to develop a system, either browser based or app based, to predict what people will talk about on social networks (e.g., Twitter). What the system should predict includes, but is not limit to: (i) what would they be talking about tomorrow, or the day after tomorrow, etc. and (ii) if they do talk about a topic, for how long and at what intensity (e.g., in terms of number of messages posted per hour). The method on hand is to extract the topics that people have talked about in the past, analyze their characteristics (e.g., are these just short-term interests that will die down very soon or they are hot topics that will last for a couple of weeks or they will recur periodically, like world soccer cup, every four years). Therefore, before you leave home, you can take a look at the screen and be 'prepared' for what to talk about when you see your friends.", "Software Technology", "project", "algorithm design; Java; interest in doing research", 2, 4, true));
            context.tblFyps.Add(new tblFyp(26, "Real-world Application Development", "In this FYP your group will develop software (e.g., a website, an app, etc.) for a real company using software engineering and database management technology. You will have to find a suitable company that will allow you to carry out the FYP. Examples of possible applications might be managing customer records, managing inventory, tracking orders and sales, managing the membership of an organization, scheduling items for shipment or delivery, providing web access (either to the public or to other companies) to a database of the items that a company sells. This FYP will give you an opportunity to apply and integrate things you have learned in various courses to a real-world problem.", "Software Technology", "project", "COMP3111 or COMP 3111H; COMP 3311; willing to work with users in a company", 1, 4, true));
            context.tblFyps.Add(new tblFyp(27, "Many-core Parallel Computing", "Commodity processors have become parallel computing platforms involving hundreds of cores. This FYT will study the state of the art in many-core parallel computing and pick a smaller topic for further investigation.", "Software Technology", "thesis", "fast learner", 1, 1, true));
            context.tblFyps.Add(new tblFyp(28, "Streaming Algorithms", "For this FYT on streaming algorithms, the student should have strong skills in algorithm design and implementation, as well as mathematics.", "Theory", "thesis", "COMP3711 or COMP3711H; algorithm design; programming; mathematics", 1, 1, true));
            context.tblFyps.Add(new tblFyp(29, "3D City Reconstruction from Images", "This FYP will investigate a methodology for the large-scale 3D reconstruction of cities from ground-level images. The goal is to produce detailed geometry and appearance that is well-suited for displaying as 'street views'. The FYP will provide key components for platforms dedicated to emerging 3D maps and digital city applications, greatly improving the current representation based on 2D panoramas.", "Vision and Graphics", "project", "C++ programming skills", 1, 4, true));
            context.tblFyps.Add(new tblFyp(30, "Photo Repairing", "Inpainting is originally a technique commonly used by conservators to unify a painting that has suffered paint loss. This FYP aims at analyzing various inpainting techniques and developing a real-world application for photo repairing (e.g., fixing damaged photos).", "Vision and Graphics", "project", "some background in mathematics and good programming skills.", 2, 3, false));

            context.tblProjectGroups.Add(new tblProjectGroup() { groupCode = "MC1", assignedFYP = 2, reader = "ray", PK_tblProjectGroups = 1 });
            context.tblProjectGroups.Add(new tblProjectGroup() { groupCode = "MC2", assignedFYP = 11, reader = "ray", PK_tblProjectGroups = 2 });
            context.tblProjectGroups.Add(new tblProjectGroup() { groupCode = "JNHJ1", assignedFYP = 5, PK_tblProjectGroups = 3 });
            context.tblProjectGroups.Add(new tblProjectGroup() { groupCode = "JNHJ2", assignedFYP = 5, reader = "cafarella", PK_tblProjectGroups = 4 });
            context.tblProjectGroups.Add(new tblProjectGroup() { groupCode = "JNHJ3", assignedFYP = 5, PK_tblProjectGroups = 5 });
            context.tblProjectGroups.Add(new tblProjectGroup() { groupCode = "HJ1", assignedFYP = 26, reader = "ruden", PK_tblProjectGroups = 6 });
            context.tblProjectGroups.Add(new tblProjectGroup() { groupCode = "JF1", assignedFYP = 30, reader = "naughton", PK_tblProjectGroups = 7 });
            context.tblProjectGroups.Add(new tblProjectGroup() { groupCode = "JN1", assignedFYP = 4, reader = "fan", PK_tblProjectGroups = 8 });
            context.tblProjectGroups.Add(new tblProjectGroup() { groupCode = "NH1", assignedFYP = 13, reader = "naughton", PK_tblProjectGroups = 9 });
            context.tblProjectGroups.Add(new tblProjectGroup(10, null, null, null));
            context.tblProjectGroups.Add(new tblProjectGroup(11, null, null, null));
            context.tblProjectGroups.Add(new tblProjectGroup(12, null, null, null));
            context.tblProjectGroups.Add(new tblProjectGroup(13, null, null, null));
            context.tblProjectGroups.Add(new tblProjectGroup(14, null, null, null));
            context.tblProjectGroups.Add(new tblProjectGroup(15, null, null, null));
            context.tblProjectGroups.Add(new tblProjectGroup(16, null, null, null));

            context.tblSupervises.Add(new tblSupervis("cafarella", 1));
            context.tblSupervises.Add(new tblSupervis("cafarella", 2));
            context.tblSupervises.Add(new tblSupervis("cafarella", 11));
            context.tblSupervises.Add(new tblSupervis("cafarella", 12));
            context.tblSupervises.Add(new tblSupervis("fan", 29));
            context.tblSupervises.Add(new tblSupervis("fan", 30));
            context.tblSupervises.Add(new tblSupervis("garcia", 17));
            context.tblSupervises.Add(new tblSupervis("garcia", 18));
            context.tblSupervises.Add(new tblSupervis("garcia", 23));
            context.tblSupervises.Add(new tblSupervis("hui", 13));
            context.tblSupervises.Add(new tblSupervis("hui", 22));
            context.tblSupervises.Add(new tblSupervis("jag", 5));
            context.tblSupervises.Add(new tblSupervis("jag", 6));
            context.tblSupervises.Add(new tblSupervis("jag", 7));
            context.tblSupervises.Add(new tblSupervis("jag", 8));
            context.tblSupervises.Add(new tblSupervis("jag", 9));
            context.tblSupervises.Add(new tblSupervis("jag", 24));
            context.tblSupervises.Add(new tblSupervis("jag", 26));
            context.tblSupervises.Add(new tblSupervis("naughton", 3));
            context.tblSupervises.Add(new tblSupervis("naughton", 4));
            context.tblSupervises.Add(new tblSupervis("naughton", 5));
            context.tblSupervises.Add(new tblSupervis("naughton", 7));
            context.tblSupervises.Add(new tblSupervis("naughton", 19));
            context.tblSupervises.Add(new tblSupervis("pantel", 8));
            context.tblSupervises.Add(new tblSupervis("pantel", 9));
            context.tblSupervises.Add(new tblSupervis("pantel", 12));
            context.tblSupervises.Add(new tblSupervis("pantel", 13));
            context.tblSupervises.Add(new tblSupervis("pantel", 21));
            context.tblSupervises.Add(new tblSupervis("parames", 15));
            context.tblSupervises.Add(new tblSupervis("parames", 16));
            context.tblSupervises.Add(new tblSupervis("parames", 18));
            context.tblSupervises.Add(new tblSupervis("parames", 20));
            context.tblSupervises.Add(new tblSupervis("ray", 10));
            context.tblSupervises.Add(new tblSupervis("ruden", 14));
            context.tblSupervises.Add(new tblSupervis("ruden", 28));
            context.tblSupervises.Add(new tblSupervis("soliman", 21));
            context.tblSupervises.Add(new tblSupervis("soliman", 25));
            context.tblSupervises.Add(new tblSupervis("soliman", 27));

            context.tblRequirementGrades.Add(new tblRequirementGrade("naughton", "lesterlo", 66, 72, 75, 80));
            context.tblRequirementGrades.Add(new tblRequirementGrade("cafarella", "lesterlo", 66, 72, 75, 80));
            context.tblRequirementGrades.Add(new tblRequirementGrade("hui", "terrytam", 75, 67, 72, 77));
            context.tblRequirementGrades.Add(new tblRequirementGrade("naughton", "terrytam", 70, 65, 75, 80));

            context.tblCSEStudents.Add(new tblCSEStudent("brunoho", "Bruno Ho", 1));
            context.tblCSEStudents.Add(new tblCSEStudent("daisyyeung", "Daisy Yeung", 2));
            context.tblCSEStudents.Add(new tblCSEStudent("adamau", "Adam Au", 3));
            context.tblCSEStudents.Add(new tblCSEStudent("lesterlo", "Lester Lo", 4));
            context.tblCSEStudents.Add(new tblCSEStudent("shirleysit", "Shirley Sit", 5));
            context.tblCSEStudents.Add(new tblCSEStudent("frankfung", "Frank Fung", 6));
            context.tblCSEStudents.Add(new tblCSEStudent("larrylai", "Larry Lai", 6));
            context.tblCSEStudents.Add(new tblCSEStudent("fredfan", "Fred Fan", 7));
            context.tblCSEStudents.Add(new tblCSEStudent("jennyjones", "Jenny Jones", 7));
            context.tblCSEStudents.Add(new tblCSEStudent("timothytu", "Timothy Tu", 7));
            context.tblCSEStudents.Add(new tblCSEStudent("brianma", "Brian Ma", 8));
            context.tblCSEStudents.Add(new tblCSEStudent("kathyko", "Kathy Ko", 8));
            context.tblCSEStudents.Add(new tblCSEStudent("monicama", "Monica Ma", 8));
            context.tblCSEStudents.Add(new tblCSEStudent("susansze", "Susan Sze", 8));
            context.tblCSEStudents.Add(new tblCSEStudent("terrytam", "Terry Tam", 9));
            context.tblCSEStudents.Add(new tblCSEStudent("sharonsu", "Sharon Su", 10));
            context.tblCSEStudents.Add(new tblCSEStudent("wendywong", "Wendy Wong", 11));
            context.tblCSEStudents.Add(new tblCSEStudent("ireneip", "Irene Ip", 12));
            context.tblCSEStudents.Add(new tblCSEStudent("peterpoon", "Peter Poon", 12));
            context.tblCSEStudents.Add(new tblCSEStudent("tiffanytan", "Tiffany Tan", 13));
            context.tblCSEStudents.Add(new tblCSEStudent("victoriayu", "Victoria Yu", 13));
            context.tblCSEStudents.Add(new tblCSEStudent("dannydoan", "Danny Doan", 13));
            context.tblCSEStudents.Add(new tblCSEStudent("carolchen", "Carol Chen", 14));
            context.tblCSEStudents.Add(new tblCSEStudent("cindychan", "Cindy Chan", 14));
            context.tblCSEStudents.Add(new tblCSEStudent("tracytse", "Tracy Tse", 14));
            context.tblCSEStudents.Add(new tblCSEStudent("yvonneyu", "Yvonne Yu", 14));
            context.tblCSEStudents.Add(new tblCSEStudent("clintchu", "Clint Chu", 15));
            context.tblCSEStudents.Add(new tblCSEStudent("amandahui", "Amanda Hui", 15));
            context.tblCSEStudents.Add(new tblCSEStudent("henryho", "Henry Ho", 16));
            context.tblCSEStudents.Add(new tblCSEStudent("tonytong", "Tony Tong", 16));
            context.tblCSEStudents.Add(new tblCSEStudent("walterwu", "Walter Wu", 16));
            context.tblCSEStudents.Add(new tblCSEStudent("xavierxie", "Xavier Xie", 16));
            context.tblCSEStudents.Add(new tblCSEStudent("steviesu", "Stevie Su", null));
            context.tblCSEStudents.Add(new tblCSEStudent("rezanlim", "Rezan Lim", null));
            context.tblCSEStudents.Add(new tblCSEStudent("bradybond", "Brady Bond", null));
            context.tblCSEStudents.Add(new tblCSEStudent("vivianso", "Vivian So", null));
            context.tblCSEStudents.Add(new tblCSEStudent("alanseto", "Alan Seto", null));
            context.tblCSEStudents.Add(new tblCSEStudent("lucylam", "Lucy Lam", null));
            context.tblCSEStudents.Add(new tblCSEStudent("hughhawes", "Hugh Hawes", null));
            context.tblCSEStudents.Add(new tblCSEStudent("carlchan", "Carl Chan", null));

            context.tblInterestedIns.Add(new tblInterestedIn(1, 6, 1));
            context.tblInterestedIns.Add(new tblInterestedIn(1, 11, 1));
            context.tblInterestedIns.Add(new tblInterestedIn(2, 1, 2));
            context.tblInterestedIns.Add(new tblInterestedIn(2, 2, 1));
            context.tblInterestedIns.Add(new tblInterestedIn(2, 3, 1));
            context.tblInterestedIns.Add(new tblInterestedIn(3, 3, 5));
            context.tblInterestedIns.Add(new tblInterestedIn(3, 10, 2));
            context.tblInterestedIns.Add(new tblInterestedIn(4, 8, 1));
            context.tblInterestedIns.Add(new tblInterestedIn(5, 3, 4));
            context.tblInterestedIns.Add(new tblInterestedIn(5, 4, 1));
            context.tblInterestedIns.Add(new tblInterestedIn(5, 5, 1));
            context.tblInterestedIns.Add(new tblInterestedIn(5, 11, 2));
            context.tblInterestedIns.Add(new tblInterestedIn(7, 9, 3));
            context.tblInterestedIns.Add(new tblInterestedIn(8, 12, 1));
            context.tblInterestedIns.Add(new tblInterestedIn(8, 7, 3));
            context.tblInterestedIns.Add(new tblInterestedIn(10, 8, 3));
            context.tblInterestedIns.Add(new tblInterestedIn(10, 14, 3));
            context.tblInterestedIns.Add(new tblInterestedIn(11, 1, 1));
            context.tblInterestedIns.Add(new tblInterestedIn(11, 2, 2));
            context.tblInterestedIns.Add(new tblInterestedIn(11, 3, 3));
            context.tblInterestedIns.Add(new tblInterestedIn(12, 7, 2));
            context.tblInterestedIns.Add(new tblInterestedIn(13, 9, 5));
            context.tblInterestedIns.Add(new tblInterestedIn(16, 12, 2));
            context.tblInterestedIns.Add(new tblInterestedIn(16, 13, 1));
            context.tblInterestedIns.Add(new tblInterestedIn(17, 14, 4));
            context.tblInterestedIns.Add(new tblInterestedIn(18, 3, 3));
            context.tblInterestedIns.Add(new tblInterestedIn(18, 5, 2));
            context.tblInterestedIns.Add(new tblInterestedIn(18, 10, 1));
            context.tblInterestedIns.Add(new tblInterestedIn(18, 7, 4));
            context.tblInterestedIns.Add(new tblInterestedIn(19, 12, 3));
            context.tblInterestedIns.Add(new tblInterestedIn(20, 10, 3));
            context.tblInterestedIns.Add(new tblInterestedIn(20, 12, 4));
            context.tblInterestedIns.Add(new tblInterestedIn(20, 13, 2));
            context.tblInterestedIns.Add(new tblInterestedIn(21, 14, 2));
            context.tblInterestedIns.Add(new tblInterestedIn(23, 9, 1));
            context.tblInterestedIns.Add(new tblInterestedIn(24, 8, 2));
            context.tblInterestedIns.Add(new tblInterestedIn(25, 12, 5));
            context.tblInterestedIns.Add(new tblInterestedIn(26, 6, 1));
            context.tblInterestedIns.Add(new tblInterestedIn(26, 10, 1));
            context.tblInterestedIns.Add(new tblInterestedIn(26, 14, 1));
            context.tblInterestedIns.Add(new tblInterestedIn(29, 8, 4));
            context.tblInterestedIns.Add(new tblInterestedIn(30, 6, 2));
            context.tblInterestedIns.Add(new tblInterestedIn(30, 7, 1));*/

            context.SaveChanges();
        }
    }
}
