<form method="get">
    <textarea name="text" rows="4" cols="40"></textarea> <br>
    <input type="submit" />
</form>

<?php

if (isset($_GET['text']))
{
	$text = $_GET['text'];
    $text = str_replace("<a href=\"", "[URL=", $text);
    $text = str_replace("\">", "]", $text);
    $text = str_replace("</a>", "[/URL]", $text);
    echo htmlentities($text);
}

?>