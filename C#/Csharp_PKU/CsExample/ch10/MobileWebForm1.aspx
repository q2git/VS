<%@ Page language="c#" Codebehind="MobileWebForm1.aspx.cs" Inherits="MobileWebApplication1.MobileWebForm1" AutoEventWireup="false" %>
<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile, Version=1.0.3300.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" %>
<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
<meta content="C#" name="CODE_LANGUAGE">
<meta content="http://schemas.microsoft.com/Mobile/Page" name="vs_targetSchema">
<body Xmlns:mobile="http://schemas.microsoft.com/Mobile/WebForm">
	<mobile:form id="Form1" runat="server">
		<FONT face="����">
			<mobile:Label id="Label1" runat="server">���</mobile:Label>
			<mobile:TextBox id="TextBox1" runat="server" Numeric="True"></mobile:TextBox>
			<mobile:Command id="Command1" runat="server">����</mobile:Command>
		</FONT>
	</mobile:form>
	<FONT face="����">
		<mobile:form id="Form2" runat="server">
			<mobile:Label id="Label2" runat="server">����</mobile:Label>
			<mobile:SelectionList id="SelectionList1" runat="server"></mobile:SelectionList>
			<mobile:Command id="Command2" runat="server">���л���</mobile:Command>
		</mobile:form>
		<mobile:form id="Form3" runat="server">
			<mobile:Label id="label3" runat="server">���</mobile:Label>
			<mobile:Link id="Link1" runat="server" NavigateUrl="#Form1">���¿�ʼ</mobile:Link>
		</mobile:form>
	</FONT>
</body>
