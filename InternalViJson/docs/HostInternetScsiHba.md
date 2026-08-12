# Vcenter.ViJson.OpenApi.Model.HostInternetScsiHba

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The linkable identifier.  | [optional] 
**Device** | **string** | The device name of host bus adapter.  | 
**Bus** | **int** | The host bus number.  | 
**Status** | **string** | The operational status of the adapter.  Valid values include \&quot;online\&quot;, \&quot;offline\&quot;, \&quot;unbound\&quot;, and \&quot;unknown\&quot;.  | 
**Model** | **string** | The model name of the host bus adapter.  | 
**Driver** | **string** | The name of the driver.  | [optional] 
**Pci** | **string** | The Peripheral Connect Interface (PCI) ID of the device representing the host bus adapter.  | [optional] 
**StorageProtocol** | **string** | The type of protocol supported by the host bus adapter.  The list of supported values is described in *HostStorageProtocol_enum*. When unset, a default value of \&quot;scsi\&quot; is assumed.  | [optional] 
**DriverVersion** | **string** | The host bus adapter driver version.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**FirmwareVersion** | **string** | The host bus adapter firmware version.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**IsSoftwareBased** | **bool** | True if this host bus adapter is a software based initiator utilizing the hosting system&#39;s existing TCP/IP network connection  | 
**CanBeDisabled** | **bool** | Can this adapter be disabled  | [optional] 
**NetworkBindingSupport** | **HostInternetScsiHbaNetworkBindingSupportTypeEnum** | Specifies if this iSCSI Adapter requires a bound network interface to function.  | [optional] 
**DiscoveryCapabilities** | [**HostInternetScsiHbaDiscoveryCapabilities**](HostInternetScsiHbaDiscoveryCapabilities.md) | The discovery capabilities for this host bus adapter.  | 
**DiscoveryProperties** | [**HostInternetScsiHbaDiscoveryProperties**](HostInternetScsiHbaDiscoveryProperties.md) | The discovery settings for this host bus adapter.  | 
**AuthenticationCapabilities** | [**HostInternetScsiHbaAuthenticationCapabilities**](HostInternetScsiHbaAuthenticationCapabilities.md) | The authentication capabilities for this host bus adapter.  | 
**AuthenticationProperties** | [**HostInternetScsiHbaAuthenticationProperties**](HostInternetScsiHbaAuthenticationProperties.md) | The authentication settings for this host bus adapter.  All static and discovery targets will inherit the use of these settings unless their authentication settings are explicitly set.  | 
**DigestCapabilities** | [**HostInternetScsiHbaDigestCapabilities**](HostInternetScsiHbaDigestCapabilities.md) | The authentication capabilities for this host bus adapter.  | [optional] 
**DigestProperties** | [**HostInternetScsiHbaDigestProperties**](HostInternetScsiHbaDigestProperties.md) | The digest settings for this host bus adapter.  All static and discovery targets will inherit the use of these properties unless their digest settings are explicitly set.  | [optional] 
**IpCapabilities** | [**HostInternetScsiHbaIPCapabilities**](HostInternetScsiHbaIPCapabilities.md) | The IP capabilities for this host bus adapter.  | 
**IpProperties** | [**HostInternetScsiHbaIPProperties**](HostInternetScsiHbaIPProperties.md) | The IP settings for this host bus adapter.  | 
**SupportedAdvancedOptions** | [**List&lt;OptionDef&gt;**](OptionDef.md) | A list of supported key/value pair advanced options for the host bus adapter including their type information.  | [optional] 
**AdvancedOptions** | [**List&lt;HostInternetScsiHbaParamValue&gt;**](HostInternetScsiHbaParamValue.md) | A list of the current options settings for the host bus adapter.  | [optional] 
**IScsiName** | **string** | The iSCSI name of this host bus adapter.  | 
**IScsiAlias** | **string** | The iSCSI alias of this host bus adapter.  | [optional] 
**ConfiguredSendTarget** | [**List&lt;HostInternetScsiHbaSendTarget&gt;**](HostInternetScsiHbaSendTarget.md) | The configured iSCSI send target entries.  | [optional] 
**ConfiguredStaticTarget** | [**List&lt;HostInternetScsiHbaStaticTarget&gt;**](HostInternetScsiHbaStaticTarget.md) | The configured iSCSI static target entries.  | [optional] 
**MaxSpeedMb** | **int** | The maximum supported link speed of the port in megabits per second.  | [optional] 
**CurrentSpeedMb** | **int** | The Current operating link speed of the port in megabits per second.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

