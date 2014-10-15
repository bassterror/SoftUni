<form method="get">
    Text: <br><textarea name="text" rows="4" cols="40"></textarea> <br>
    Bannlist: <br><input type="text" name="bann" /> <br>
    <input type="submit" />
</form>

<?php

if (isset($_GET['text']) && isset($_GET['bann'])){
	$text = $_GET['text'];
    $bann = explode(", ", $_GET['bann']);
    
    foreach ($bann as $word){
        $replacement = '';
        for ($i = 0; $i < strlen($word); $i++)
        {
        	$replacement .= '*';
        }
        
    	$text = str_replace($word, $replacement, $text);
    }
    echo $text;
}

?>