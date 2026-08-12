# Vcenter.ViJson.OpenApi.Model.CustomizationLinuxPrep

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostName** | [**CustomizationName**](CustomizationName.md) | The network host name of the (Linux) virtual machine.  | 
**Domain** | **string** | The fully qualified domain name.  | 
**VarTimeZone** | **string** | The case-sensitive timezone, such as Europe/Sofia.  &lt;a href&#x3D;\&quot;timezone.html\&quot;title&#x3D;\&quot;Display list of Valid timeZone values...\&quot;&gt; **Valid timeZone values**&lt;/a&gt; are based on the tz (timezone) database used by Linux and other Unix systems. The values are strings (xsd:string) in the form \&quot;Area/Location,\&quot; in which Area is a continent or ocean name, and Location is the city, island, or other regional designation.  See the &lt;a href&#x3D;\&quot;https://kb.vmware.com/selfservice/microsites/search.do?language&#x3D;en_US&amp;cmd&#x3D;displayKC&amp;externalId&#x3D;2145518\&quot;target&#x3D;\&quot;_blank\&quot;&gt;List of supported time zones for different vSphere versions in Linux/Unix systems&lt;/a&gt;.  | [optional] 
**HwClockUTC** | **bool** | Specifies whether the hardware clock is in UTC or local time. - True when the hardware clock is in UTC. - False when the hardware clock is in local time.  | [optional] 
**ScriptText** | **string** | The script to run before and after GOS customization.  | [optional] 
**CompatibleCustomizationMethod** | **string** | The compatible customization method is an identifier of a customization strategy which is implementable in a group of Linux operating systems.  This value does not need to be set if your operating system is officially supported by VMware guest operating system customization. When using a Linux operating system which hasn&#39;t been officially supported and it is designed to be 100% bug-for-bug compatible with an officially supported Linux operating system, it can be customized by an existing customization method.  Please set the compatible customization method to a supported string value e.g. \&quot;GOSC\\_METHOD\\_1\&quot;.   See &lt;a href&#x3D;\&quot;https://kb.vmware.com/s/article/95903\&quot;target&#x3D;\&quot;_blank\&quot;&gt;Supported compatible customization method list&lt;/a&gt;.  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 
**ResetPassword** | **bool** | Require root accounts to change their password on first login after customization.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**Password** | [**CustomizationPassword**](CustomizationPassword.md) | Password set for root accounts.  The password value must be a non-empty string. If this field is not set, the root password will remain unchanged.  Set the plainText flag to indicate whether the value is plain text or encrypted.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**ExtraConfig** | [**List&lt;OptionValue&gt;**](OptionValue.md) | Additional key/value pairs to support third party customization.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

