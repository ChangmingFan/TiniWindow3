<?php
session_start();
?>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml"><!-- InstanceBegin template="/Templates/tinilite_template.dwt" codeOutsideHTMLIsLocked="false" -->

<head>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<link REL="SHORTCUT ICON" HREF="http://www.tinilite.net/favicon.ico" />
<?php
   
  //db.php is above root. most other include files are not
  require_once("/home/tinilite/include/db.php"); 
?>

<!-- InstanceBeginEditable name="prehead" -->
<?php

#privilege variable
#actual testing occurs after top navaigation displayed
$auth_required =  FALSE ;
$min_member = 0;
$min_admin = 0;
$min_privilege = 0;
$min_officer = 0;

?>
 



<!-- InstanceEndEditable -->


<?php

  if ($_POST['loginbutton'] == "Log Out")
  {
   
    include('logout.php');
		
  } 
 

@$authenticated = $_SESSION['authenticated'];
@$paid_member = $_SESSION['paid_member'];
@$administrator = $_SESSION['administrator'];
@$privileged_access = $_SESSION['privileged_access'];
@$officer = $_SESSION['officer'];
 
@$user = $_SESSION['user'];
//echo $user;


?>
<!-- InstanceBeginEditable name="doctitle" -->
<title>Untitled Document</title>
<!-- InstanceEndEditable --><!-- InstanceBeginEditable name="head" --><!-- InstanceEndEditable -->
<!-- InstanceParam name="login_panel" type="boolean" value="true" --><!-- InstanceParam name="logo_panel" type="boolean" value="true" --><!-- InstanceParam name="href" type="text" value="#" --><!-- InstanceParam name="OptlRegiLogin" type="boolean" value="true" -->
<link href="stylesheet.css" rel="stylesheet" type="text/css" />
</head>

<body>
<div id="layer_logo"><img src="images/Thick-Logo-small1117.jpg" alt="TiniLite logo" width="80" height="80" /></div>

<div id="Layer_advertisement">
  <table width="449" height="78" border="1">
    <tr>
      <td width="439">
	  
	    <img src="images/corp-logo-93KB.jpg" alt="Tinilite Banner" width="252" height="78" /></td>
    </tr>
  </table>
</div>

<?php
/*
<div id="Layer_search">
  <table width="250" height="80" border="1">
    <tr>
      <td>
	  <form action="<?php echo $page; ?>" method="post">
        
            <input name="search_string" value ="<?php print $user;?>" />              
          
        
        <input type="submit" name="search" value="search" />
      </form></td>
    </tr>
  </table>
</div>
*/
?>
<?php
include ('/home/tinilite/public_html/includefiles/navbar.php');
?>


<?php
include ('/home/tinilite/public_html/includefiles/logindiv.php');
?>

<div id="Layer3">
           
           

<table width="624" height="400" border="1">
  <tr>
    <td width="614"><!-- InstanceBeginEditable name="page content" --><img src="images/art.jpg" alt="Art of light" width="822" height="649" /><!-- InstanceEndEditable -->
<p align="center">Webmaster: &nbsp;&nbsp;<a href="mailto:jpdenoyer@hotmail.com">J.P. Denoyer </a> &nbsp;</p> 
</td>
  </tr>
</table>



</div>

We
<div id="Layer_links">
  <table width="80" border="1">
    <!-- InstanceBeginRepeat name="link" --><!-- InstanceBeginRepeatEntry -->
	<tr>
      <td height="50"><!-- InstanceBeginEditable name="link_edit" --><a href="#"></a><!-- InstanceEndEditable --></td>
    </tr>
	<!-- InstanceEndRepeatEntry --><!-- InstanceEndRepeat -->
    
  </table>
  <p>&nbsp;</p>
</div>

</body>
<!-- InstanceEnd --></html>
