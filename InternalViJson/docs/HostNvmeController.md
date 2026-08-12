# Vcenter.ViJson.OpenApi.Model.HostNvmeController

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The linkable identifier.  | 
**ControllerNumber** | **int** | The controller number uniquely identifies the NVME Controller within its HostSystem.  This should not be confused with Controller ID (see \&quot;NVM Express over Fabrics 1.0\&quot;, Section 4.2, \&quot;Controller model\&quot; for details), which only serves as an identifier within a particular NVME subsystem.  | 
**Subnqn** | **string** | The NVME subsystem qualified name.  Each NVME controller is associated with an NVME subsystem which can present a collection of controllers to the adapter. For more details, refer to: - \&quot;NVM Express over Fabrics 1.0\&quot;, Section 1.5.2,   \&quot;NVM Subsystem\&quot;.  | 
**Name** | **string** | Name of the controller.  Each controller has a name. For NVME over Fabrics controllers, it is generated when the controller is connected to an NVME over Fabrics adapter.  | 
**AssociatedAdapter** | **string** | Associated NVME over Fabrics host bus adapter.  A controller is associated with exactly one host at a time through an NVME over Fabrics host bus adapter.  | 
**TransportType** | **string** | The transport type supported by the controller.  The set of possible values is described in *HostNvmeTransportType_enum*. For details, see: - \&quot;NVM Express over Fabrics 1.0\&quot;, Section 1.5.1,   \&quot;Fabrics and Transports\&quot;.  | 
**FusedOperationSupported** | **bool** | Indicates whether fused operations are supported by the controller.  An NVME controller may support fused operations. This is required to support shared storage, otherwise data corruption may occur. For more details, see: - \&quot;NVM Express 1.3\&quot;, Section 6.2, \&quot;Fused Operations\&quot;.  | 
**NumberOfQueues** | **int** | The number of I/O queues allocated for the controller.  | 
**QueueSize** | **int** | The size of each of the I/O queues.  This will not be greater than the Maximum Queue Entries Supported (mqes) value for the controller. For more information, see: - \&quot;NVM Express 1.3\&quot;, section 3.1, \&quot;Register definition\&quot;.  | 
**AttachedNamespace** | [**List&lt;HostNvmeNamespace&gt;**](HostNvmeNamespace.md) | List of NVME namespaces attached to the controller.  Namespaces provide access to a non-volatile storage medium which is part of the NVM subsystem. For an overview, see: - \&quot;NVM Express over Fabrics 1.0\&quot;, Section 1.5.2,   \&quot;NVM Subsystem\&quot;. - \&quot;NVM Express 1.3\&quot;, section 6.1, \&quot;Namespaces\&quot;.  | [optional] 
**VendorId** | **string** | The vendor ID of the controller, if available.  | [optional] 
**Model** | **string** | The model name of the controller, if available.  | [optional] 
**SerialNumber** | **string** | The serial number of the controller, if available.  | [optional] 
**FirmwareVersion** | **string** | The firmware version of the controller, if available.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

