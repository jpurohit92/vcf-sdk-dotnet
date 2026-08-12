# Vcenter.ViJson.OpenApi.Model.VirtualSerialPortPipeBackingInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PipeName** | **string** | Pipe name for the host pipe associated with this backing.  | 
**Endpoint** | **string** | Indicates the role the virtual machine assumes as an endpoint for the pipe.  The valid values are \&quot;client\&quot; or \&quot;server\&quot;.  | 
**NoRxLoss** | **bool** | Enables optimized data transfer over the pipe.  When you use this feature, the ESX server buffers data to prevent data overrun. This allows the virtual machine to read all of the data transferred over the pipe with no data loss. To use optimized data transfer, set &lt;code&gt;noRxLoss&lt;/code&gt; to &lt;code&gt;true&lt;/code&gt;. To disable this feature, set the property to &lt;code&gt;false.  This property is optional. If this property is not set, the ESX server uses the default value specified in the pipe backing options (noRxLoss.defaultValue - see &lt;code&gt;*VirtualSerialPortPipeBackingOption.noRxLoss*&lt;/code&gt; in the pipe backing option object).  To use this property, optimized data transfer must be supported on the host. (See &lt;code&gt;*VirtualSerialPortPipeBackingOption.noRxLoss*&lt;/code&gt; in the pipe backing option object.) If the ESX server does not support the option, it ignores the &lt;code&gt;noRxLoss&lt;/code&gt; setting in the pipe backing information object.  **Note**: You can use this feature even if the other end of the pipe is not an application, but this is more likely to fail.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

