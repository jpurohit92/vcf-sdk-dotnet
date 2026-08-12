# Vcenter.ViJson.OpenApi.Model.VirtualE1000Option
The VirtualE1000 option data object type contains the options for the *VirtualE1000* data object type. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SupportedOUI** | [**ChoiceOption**](ChoiceOption.md) | The valid Organizational Unique Identifiers (OUIs) supported by this virtual Ethernet card.  &lt;dl&gt; &lt;dt&gt;Supported OUIs for statically assigned MAC addresses:&lt;/dt&gt; &lt;dd&gt;\&quot;00:50:56\&quot;&lt;/dd&gt; &lt;/dl&gt;  | 
**MacType** | [**ChoiceOption**](ChoiceOption.md) | The supported MAC address types.  | 
**WakeOnLanEnabled** | [**BoolOption**](BoolOption.md) | Flag to indicate whether or not wake-on-LAN is settable on this device.  | 
**VmDirectPathGen2Supported** | **bool** | Deprecated as of vSphere API 8.0. VMDirectPath Gen 2 is no longer supported and there is no replacement.  Flag to indicate whether VMDirectPath Gen 2 is available on this device.  | [optional] 
**UptCompatibilityEnabled** | [**BoolOption**](BoolOption.md) | Deprecated as of vSphere API 8.0. VMDirectPath Gen 2 is no longer supported and there is no replacement.  Flag to indicate whether Universal Pass-through(UPT) is settable on this device.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

