# Vcenter.ViJson.OpenApi.Model.VirtualVmxnet
The VirtualVmxnet data object type represents an instance of the Vmxnet virtual Ethernet adapter attached to a virtual machine. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DynamicProperty** | [**List&lt;DynamicProperty&gt;**](DynamicProperty.md) | Set of dynamic properties.  This property is optional because only the properties of an object that are unknown to a client will be part of this set. This property is not readonly just in case we want to send such properties from a client in the future.  | [optional] 
**AddressType** | **string** | MAC address type.  Valid values for address type are: &lt;dl&gt; &lt;dt&gt;Manual&lt;/dt&gt; &lt;dd&gt;Statically assigned MAC address.&lt;/dd&gt; &lt;dt&gt;Generated&lt;/dt&gt; &lt;dd&gt;Automatically generated MAC address.&lt;/dd&gt; &lt;dt&gt;Assigned&lt;/dt&gt; &lt;dd&gt;MAC address assigned by VirtualCenter.&lt;/dd&gt; &lt;/dl&gt;  | [optional] 
**MacAddress** | **string** | MAC address assigned to the virtual network adapter.  Clients can set this property to any of the allowed address types. The server might override the specified value for \&quot;Generated\&quot; or \&quot;Assigned\&quot; if it does not fall in the right ranges or is determined to be a duplicate.  | [optional] 
**WakeOnLanEnabled** | **bool** | Indicates whether wake-on-LAN is enabled on this virtual network adapter.  Clients can set this property to selectively enable or disable wake-on-LAN.  | [optional] 
**ResourceAllocation** | [**VirtualEthernetCardResourceAllocation**](VirtualEthernetCardResourceAllocation.md) | Resource requirements of the virtual network adapter  | [optional] 
**ExternalId** | **string** | An ID assigned to the virtual network adapter by external management plane or controller.  The value and format of this property is determined by external management plane or controller, and vSphere doesn&#39;t do any validation. It&#39;s also up to external management plane or controller to set, unset or maintain this property. Setting this property with an empty string value will unset the property.  | [optional] 
**UptCompatibilityEnabled** | **bool** | Deprecated as of vSphere API 8.0. VMDirectPath Gen 2 is no longer supported and there is no replacement.  Indicates whether UPT(Universal Pass-through) compatibility is enabled on this network adapter.  UPT is only compatible for Vmxnet3 adapter. Clients can set this property enabled or disabled if ethernet virtual device is Vmxnet3.  | [optional] 
**SubnetId** | **string** | The ID of the subnet the virtual network adapter connects to.  It is only set when the virtual network adapter is connected to a subnet.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

