<?php
	require("conectabd.php");	
	$sql="SELECT * FROM Usuarios_IDE ";
	$resultado=mysqli_query($conexion,$sql);	
	if(!$resultado)
	{
		echo "Error";
	}
	else
	{		
		$nr=mysqli_num_rows($resultado);
		if($nr>=1)
		{	$json='{"usuarios":[';
			for($cont=1;$cont<=$nr;$cont++)
			{
				$row=mysqli_fetch_object($resultado);
				$encode=json_encode($row);
				if(is_string($encode))
				{
					if($cont<$nr)
						$json=$json.$encode.",";
					else
						$json=$json.$encode;
				}
				
			}
			$json=$json."]}";						
			echo "$json";
		}
		else
		{
			$error="{}";
			echo $error;		
		}	
	}
	mysqli_close($conexion);
?>