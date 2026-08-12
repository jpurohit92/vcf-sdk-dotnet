# Vcenter.ViJson.OpenApi.Model.EventEx

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **int** | The event ID.  | 
**ChainId** | **int** | The parent or group ID.  | 
**CreatedTime** | **DateTime** | The time the event was created.  | 
**UserName** | **string** | The user who caused the event.  | 
**Datacenter** | [**DatacenterEventArgument**](DatacenterEventArgument.md) | The Datacenter object of the event.  | [optional] 
**ComputeResource** | [**ComputeResourceEventArgument**](ComputeResourceEventArgument.md) | The ComputeResource object of the event.  | [optional] 
**Host** | [**HostEventArgument**](HostEventArgument.md) | The Host object of the event.  | [optional] 
**Vm** | [**VmEventArgument**](VmEventArgument.md) | The VirtualMachine object of the event.  | [optional] 
**Ds** | [**DatastoreEventArgument**](DatastoreEventArgument.md) | The Datastore object of the event.  | [optional] 
**Net** | [**NetworkEventArgument**](NetworkEventArgument.md) | The Network object of the event.  | [optional] 
**Dvs** | [**DvsEventArgument**](DvsEventArgument.md) | The DistributedVirtualSwitch object of the event.  | [optional] 
**Tgw** | [**TgwEventArgument**](TgwEventArgument.md) | The TransitGateway object of the event.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**FullFormattedMessage** | **string** | A formatted text message describing the event.  The message may be localized.  | [optional] 
**ChangeTag** | **string** | The user entered tag to identify the operations and their side effects  | [optional] 
**AuditId** | **string** | Specifies the name of the audit event.  The value must never be empty. If unset, the event is not related to auditable activity.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**EventTypeId** | **string** | The type of the event.  | 
**Severity** | **string** | The severity level of the message: null&#x3D;&amp;gt;info.  See also *EventEventSeverity_enum*.  | [optional] 
**Message** | **string** | An arbitrary message string, not localized.  | [optional] 
**Arguments** | [**List&lt;KeyAnyValue&gt;**](KeyAnyValue.md) | The event arguments associated with the event  | [optional] 
**ObjectId** | **string** | The ID of the object (VM, Host, Folder..) which the event pertains to.  Federated or local inventory path.  | [optional] 
**ObjectType** | **string** | the type of the object, if known to the VirtualCenter inventory  | [optional] 
**ObjectName** | **string** | The name of the object  | [optional] 
**Fault** | [**MethodFault**](MethodFault.md) | The fault that triggered the event, if any  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

