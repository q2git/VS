try
{
	net.xml_webservices.www.clock clock1 = 
		new net.xml_webservices.www.clock();
	DateTime nowX = clock1.GetUTC_Time( );
	Console.WriteLine( nowX );
}
catch(Exception e )
{
	Console.WriteLine(e );
}
// �÷���������:
//  http://www.xml-webservices.net/services/time_server/clock.asmx