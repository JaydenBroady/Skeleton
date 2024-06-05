<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    &nbsp;<form id="form1" runat="server">
            <asp:Label ID="lblNameProduct" runat="server" style="z-index: 1; left: 6px; position: absolute; height: 20px; width: 102px; margin-bottom: 0px" Text="Product Name"></asp:Label>
            <asp:TextBox ID="txtNameProduct" runat="server" style="z-index: 1; left: 105px; top: 40px; position: absolute; width: 138px"></asp:TextBox>
        <div>
            <asp:Label ID="lblProductId" runat="server" style="z-index: 1; left: 6px; top: 16px; position: absolute" Text="ProductID" width="102px"></asp:Label>
            <asp:TextBox ID="txtProductId" runat="server" style="z-index: 1; left: 105px; top: 15px; position: absolute; width: 138px"></asp:TextBox>
        </div>
      
        <p style="width: 527px">
            <asp:TextBox ID="txtScentType" runat="server" style="z-index: 1; left: 105px; top: 81px; position: absolute; height: 18px; width: 138px"></asp:TextBox>
            <asp:Label ID="lblScentType" runat="server" style="z-index: 1; left: 6px; top: 84px; position: absolute; width: 102px; height: 20px" Text="Scent Type"></asp:Label>
        </p>
        <asp:Label ID="lblOccasion" runat="server" style="z-index: 1; left: 6px; top: 129px; position: absolute" Text="Occasion" width="102px"></asp:Label>
        <p>
            <asp:TextBox ID="txtOccasion" runat="server" style="z-index: 1; left: 105px; top: 129px; position: absolute; height: 16px; width: 138px"></asp:TextBox>
            <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 6px; top: 164px; position: absolute" Text="Description" width="102px"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 105px; top: 158px; position: absolute; height: 83px; width: 138px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblAvailability" runat="server" style="z-index: 1; left: 6px; top: 262px; position: absolute" Text="Availabilty" width="102px"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtAvailability" runat="server" style="z-index: 1; left: 105px; top: 275px; position: absolute; height: 16px; width: 138px"></asp:TextBox>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 6px; top: 384px; position: absolute" width="102px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 6px; top: 323px; position: absolute; height: 21px; width: 102px" Text="Price"></asp:Label>
        </p>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 105px; top: 321px; position: absolute" width="138px"></asp:TextBox>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 6px; top: 433px; position: absolute" Text="OK" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 148px; top: 433px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
