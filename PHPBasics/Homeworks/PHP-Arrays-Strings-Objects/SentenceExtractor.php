<form method="get">
    <textarea name="text" rows="4" cols="40"></textarea>
    <br>
    <input type="text" name="word" />
    <br>
    <input type="submit" />
</form>

<?php

if (isset($_GET['text']) && isset($_GET['word']))
{
	$text = $_GET['text'];
    $word = $_GET['word'];
    $sentances = preg_split("/(?<=[.?!])\s*/", $text, -1, PREG_SPLIT_NO_EMPTY);
    
    foreach ($sentances as $sentance)
    {
        if (preg_match("/\s+$word\s+.*[.?!]+$/", $sentance)) {
            echo $sentance . "<br/>";
        }
    }
}

?>