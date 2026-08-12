# Vcenter.ViJson.OpenApi.Model.AboutInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Short form of the product name.  | 
**FullName** | **string** | The complete product name, including the version information.  | 
**Vendor** | **string** | Name of the vendor of this product.  | 
**VarVersion** | **string** | Dot-separated product version string.  For example, \&quot;10.0.2.0\&quot;.  | 
**PatchLevel** | **string** | Patch level for the server.  ***Since:*** vSphere API Release 7.0.2.0  | [optional] 
**Build** | **string** | Build string for the server on which this call is made.  For example, x.y.z-num. This string does not apply to the API.  | 
**LocaleVersion** | **string** | Version of the message catalog for the current session&#39;s locale.  | [optional] 
**LocaleBuild** | **string** | Build number for the current session&#39;s locale.  Typically, this is a small number reflecting a localization change from the normal product build.  | [optional] 
**OsType** | **string** | Operating system type and architecture.  Examples of values are: - \&quot;win32-x86\&quot; - For x86-based Windows systems. - \&quot;linux-x86\&quot; - For x86-based Linux systems. - \&quot;vmnix-x86\&quot; - For the x86 ESX Server microkernel. - \&quot;vmnix-arm64\&quot; - For the arm64 ESX Server microkernel.  | 
**ProductLineId** | **string** | The product ID is a unique identifier for a product line.  Examples of values are: - \&quot;gsx\&quot; - For the VMware Server product. - \&quot;esx\&quot; - For the ESX product. - \&quot;embeddedEsx\&quot; - For the ESXi product. - \&quot;esxio\&quot; - For the ESXio product. - \&quot;vpx\&quot; - For the VirtualCenter product.  | 
**ApiType** | **string** | Indicates whether or not the service instance represents a standalone host.  If the service instance represents a standalone host, then the physical inventory for that service instance is fixed to that single host. VirtualCenter server provides additional features over single hosts. For example, VirtualCenter offers multi-host management.  Examples of values are: - \&quot;VirtualCenter\&quot; - For a VirtualCenter instance. - \&quot;HostAgent\&quot; - For host agent on an ESX Server or VMware Server host.  | 
**ApiVersion** | **string** | The newest long-term supported API version provided by the server.  The version format is \&quot;x.y.z.a\&quot;, where \&quot;x\&quot;, \&quot;y\&quot;, and \&quot;z\&quot; are numbers that do not exceed 99, and \&quot;a\&quot; does not exceed 9999.  | 
**InstanceUuid** | **string** | A globally unique identifier associated with this service instance.  | [optional] 
**LicenseProductName** | **string** | The license product name  | [optional] 
**LicenseProductVersion** | **string** | The license product version  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

