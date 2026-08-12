# Vcenter.Automation.OpenApi.Model.VcenterLcmDiscoveryProduct
The Info schema contains information about a VMware product which is present in the customer Environemnt. The following information about the products are present:     -  Name    -  Version    -  Deployments    -  Automatically Discovered or Manually Added  

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstalledProduct** | **string** | Identifies a product and a version uniquely.   The identifier consists of product internal name and version.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;PRODUCT&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;PRODUCT&#x60;. | 
**Name** | **string** | A public official product name. | 
**VarVersion** | **string** | Current product version. | 
**TargetVersion** | **string** | Future version of the product after upgrade.  target_version may not be applicable. | [optional] 
**Deployments** | **List&lt;string&gt;** | The list of hostname/IPs of the instances of the VMware products deployed in the environment. This field would be empty for manually added products. | [optional] 
**Auto** | **bool** | Indicates if the product is auto-detected by the system or manually added. If it is set to true it means it is auto-detected. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

