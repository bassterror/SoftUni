Enter HTML tags:
<form method="get">
    <input type="text" name="textbox" />
    <input type="submit" />
</form>


<?php
if(isset($_GET['textbox']) && $_GET['textbox'] <> '')
{
    session_start();
    $tags = array("a", "abbr", "address", "area", "article", "aside", "audio", "b", "base", "bdi", "bdo", "blockquote", "body", "br", "button", "canvas", "caption",
        "cite", "code", "col", "colgroup", "command", "datalist", "dd", "del", "details", "dfn", "div", "dl", "dt", "em", "embed", "fieldset", "figcaption", "figure",
        "footer", "form", "h1", "h2", "h3", "h4", "h5", "h6", "head", "header", "hgroup", "hr", "html", "i", "iframe", "img", "input", "ins", "kbd", "keygen", "label",
        "legend", "li", "link", "map", "mark", "menu", "meta", "meter", "nav", "noscript", "object", "ol", "optgroup", "option", "output", "p", "param", "pre", "progress",
        "q", "rp", "rt", "ruby", "s", "samp", "script", "section", "select", "small", "source", "span", "strong", "style", "sub", "summary", "sup", "table", "tbody", "td",
        "textarea", "tfoot", "th", "thead", "time", "title", "tr", "track", "u", "ul", "var", "video", "wbr");
    $input = $_GET['textbox'];
    if (in_array($input, $tags))
    {
    	if (!isset($_SESSION['counter']))
        {
            $_SESSION['counter'] = 1;
        } else {
            $_SESSION['counter']++;
        }
        echo "Valid HTML Tag! <br />";
    } else  {
        echo "Invalid HTML tag! <br />";
    }
    echo "Score: " . $_SESSION['counter'];
}

?>