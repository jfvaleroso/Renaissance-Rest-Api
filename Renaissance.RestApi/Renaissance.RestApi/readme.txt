open restextension.config

<?xml version="1.0" encoding="utf-8"?>
<RestExtensions>
  <!--
	<ext assembly="umbraco" type="umbraco.presentation.umbracobase.library.member" alias="currentMember">
    <permission method="login" allowAll="true" />
    <permission method="logout" allowAll="true" />
    <permission method="id" allowAll="true" />
    <permission method="data" allowAll="true" />
    <permission method="logout" allowAll="true" />
    <permission method="setProperty" allowAll="false" />
  </ext>
-->

  <ext assembly="Renaissance.RestApi" type="Renaissance.RestApi.Training" alias="training">
    <permission method="HelloWorld" allowAll="true" />
    <permission method="Hello" allowAll="true" />
    <permission method="GetDataById" allowAll="true" />
    <permission method="Create" allowAll="true" />
  </ext>
  
</RestExtensions>