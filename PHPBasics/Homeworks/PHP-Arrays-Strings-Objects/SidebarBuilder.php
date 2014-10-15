<form method="get">
    <input type="text" name="cats" /> <br>
	<input type="text" name="tags"/> <br>
    <input type="text" name="months"/> <br>
    <input type="submit" value="Color text"/>
</form>

<?php

class SideBar
{
    public $Name;
    private $list;
    
    public function SetList($list)
    {
		$this->list = $list;
    }
    
    public function Draw()
    {
   
		echo "<div>";
        echo "<span> $this->Name </span>";
        echo "<ul>";
        foreach($this->list as $item)
        {
            echo "<li> $item </li>";
        }
        
        echo "</ul>";
        echo "</div>";
    }
}

$bar = new SideBar();

if (isset($_GET["cats"]))
{
    $cats = $_GET["cats"];
	$bar->Name = "Category";
    $bar->SetList(split(", ",$cats));
    $bar->Draw();
}

if (isset($_GET["tags"]))
{
    $tags = $_GET["tags"];
	$bar->Name = "Tags";
    $bar->SetList(split(", ",$tags));
    $bar->Draw();
}

if (isset($_GET["months"]))
{
    $months = $_GET["months"];
	$bar->Name = "Months";
    $bar->SetList(split(", ",$months));
    $bar->Draw();
}


?>