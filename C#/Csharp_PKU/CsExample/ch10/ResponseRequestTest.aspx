<%@ Page language="c#"%>
<html>
<body>
������һ���򵥵�ASP.NET�ļ���

<form method=post>
<p>��������Ҫ��ʾ�����ֵĸ��� 
<input type=text name=num>
<input type=submit>
</form>
<p>
<%
string sn = Request["num"];
int n = 0;
try
{
	n = int.Parse( sn );
}catch{}

for( int i=0; i<n; i++ )
	Response.Write( i + " " );
%>

</body>
</html>
