# Vcenter.ViJson.OpenApi.Model.VirtualSerialPortPipeBackingOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Endpoint** | [**ChoiceOption**](ChoiceOption.md) | Indicates the choices available and the default setting for the pipe endpoint.  As an endpoint, the virtual machine can act as a client or a server.  | 
**NoRxLoss** | [**BoolOption**](BoolOption.md) | Indicates whether the server supports optimized data transfer over the pipe and also specifies default behavior.  When this feature is supported and enabled, the server buffers data to prevent data overrun. This allows the virtual machine to read all of the data transferred over the pipe with no data loss.  If optimized data transfer is supported (&lt;code&gt;noRxLoss.supported&lt;/code&gt; is &lt;code&gt;true&lt;/code&gt;): - You can enable (or disable) the feature explicitly by setting the   &lt;code&gt;*VirtualSerialPortPipeBackingInfo.noRxLoss*&lt;/code&gt;   property on the pipe backing information object. - If you do not set the   &lt;code&gt;*VirtualSerialPortPipeBackingInfo.noRxLoss*&lt;/code&gt;   property on the   the pipe backing information object, the server enables   optimized data transfer if the &lt;code&gt;noRxLoss.defaultValue&lt;/code&gt;   property on the pipe backing options object is &lt;code&gt;true&lt;/code&gt;.    If &lt;code&gt;noRxLoss.supported&lt;/code&gt; is &lt;code&gt;false&lt;/code&gt;, the server ignores the optimization settings.  **Note**: You can use this feature even if the other end of the pipe is not an application, but it is more likely to fail.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

