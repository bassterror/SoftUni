<form method="get">
    <input type="text" name="textbox" /> <br>
    <input type="submit" value="Color text"/>
</form>

<?php

if (isset($_GET["textbox"]))
{
	$input = $_GET['textbox'];
 
 
    for($i = 0;$i < strlen($input);$i++)
    {
       $letter = mb_substr($input,$i,1);
      
       if($letter != " ")
        {
           
            $code = ord($letter);
            $color = "";
            if($code % 2 == 0)
            {
                $color = "red";
                 
            }
            else 
            {
                $color = "blue";
            }
            
            echo "<span style='color:$color'>$letter</span> ";
        }        
    }        
}


?>