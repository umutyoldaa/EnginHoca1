using OOP3;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager(); 
BasvuruManager basvuruManager = new BasvuruManager();

ILoggerService dataloggerService = new DatabaseLoggerService();
ILoggerService fileloggerService = new FileLoggerService();

List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,konutKrediManager,tasitKrediManager };
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);
//basvuruManager.BasvuruYap(ihtiyacKrediManager,fileloggerService);
List<ILoggerService> loggers = new List<ILoggerService> {fileloggerService,dataloggerService };
basvuruManager.BasvuruYap(new EsnafKrediManager(), loggers);