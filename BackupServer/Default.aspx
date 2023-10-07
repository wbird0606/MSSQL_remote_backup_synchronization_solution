<%@ Page Title="BackUp Server" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="backupserver._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

        <h1>BackUp Server</h1>
        <p class="lead">Powered By WeiiiiiBird</p>
        <%--<p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>--%>
    </div>

    <div class="row">
        <div class="col-md" style="font-family:DFKai-SB">
            <center>
                 <h1>操作說明</h1>
            <h2>/list</h2>
            <h3>
                列出指定資料夾完整備份檔檔名(.bak)
            </h3>
            <h2>/list_tra</h2>
            <h3>
                列出指定資料夾差異備份檔檔名(.tra)
            </h3>
            <h2>/download/{fileName}</h2>
            <h3>
                下載指定檔案
            </h3>
            </center>
           
        </div>
        <hr />
        <div class="col-md" style="font-family:DFKai-SB">
            <center>
                <h1>Q&A</h1>
            <h2>Q1:無論怎麼下載檔案都出現404 NotFound</h2>
            <img src="404NF.png" aria-atomic="True" style="width: auto" />
            <h3>
                請參閱"BackUpServer IIS設置"
            </h3>
            <h2>Q2:大家都可以訪問這個Web Server嗎?</h2>
            <h3>
                已有新增五大系統的主要和備援DB的IP到白名單，其他非經授權訪問使用者會顯示403錯誤畫面，所以不用擔心。<br />
                若還有需要再特別限制訪問，請參閱"BackUpServer IIS設置"。<br />
            </h3>
            </center>
            
        </div>
        <hr />
        <div class="col-md" style="font-family:DFKai-SB">
            <center>
                <h1>技術交流</h1>
            <h2>
                範圍請求
            </h2>
            <h3>
                在"/download/{fileName}"就有用到此技術，提高下載效率有很多種方法。<br/>本系統採用範圍請求來實現分段串流下載。其允許客戶端僅下載檔案的部分內容，而不是整個檔案。這在處理大型檔案時特別有用，因為可以避免再單次請求中下載整個檔案，而是根據需要下載檔案的不同部分來回應給用戶端。故下載時用戶端也需要針對特定的檔案片段提供給伺服器端。<br/>
                  在虛擬機實測門禁雲備份檔(63GB)下載至備援站台，所需時間在8分鐘內即可完成。如圖所示:
            </h3>
            <img src="MndBackUp.png" />
            </center>
            
        </div>
    </div>
</asp:Content>