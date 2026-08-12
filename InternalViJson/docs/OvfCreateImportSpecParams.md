# Vcenter.ViJson.OpenApi.Model.OvfCreateImportSpecParams

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Locale** | **string** | The locale-identifier to choose from the descriptor.  If empty, the default locale on the server is used.  | 
**DeploymentOption** | **string** | The key of the chosen deployment option.  If empty, the default option is chosen. The list of possible deployment options is returned in the result of parseDescriptor.  | 
**MsgBundle** | [**List&lt;KeyValue&gt;**](KeyValue.md) | An optional set of localization strings to be used.  The server will use these message strings to localize information in the result and in error and warning messages.  This argument allows a client to pass messages from external string bundles. The client is responsible for selecting the right string bundle (based on locale) and parsing the external string bundle. The passed in key/value pairs are looked up before any messages included in the OVF descriptor itself.  | [optional] 
**ImportOption** | **List&lt;string&gt;** | An optional argument for modifying the OVF parsing.  When the server parses an OVF descriptor a set of options can be used to modify the parsing. The argument is a list of keywords.  To get a list of supported keywords see *OvfManager.ovfImportOption*. Unknown options will be ignored by the server.  | [optional] 
**EntityName** | **string** | The name to set on the entity (more precisely, on the top-level vApp or VM of the entity) as it appears in VI.  If empty, the product name is obtained from the ProductSection of the descriptor. If that name is not specified, the ovf:id of the top-level entity is used.  | 
**HostSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host to validate the OVF descriptor against, if it cannot be deduced from the resource pool.  The privilege System.Read is required on the host.  Refers instance of *HostSystem*.  | [optional] 
**NetworkMapping** | [**List&lt;OvfNetworkMapping&gt;**](OvfNetworkMapping.md) | The mapping of network identifiers from the descriptor to networks in the VI infrastructure.  The privilege Network.Assign is required on all networks in the list.  | [optional] 
**IpAllocationPolicy** | **string** | The IP allocation policy chosen by the caller.  See *VAppIPAssignmentInfo*.  | [optional] 
**IpProtocol** | **string** | The IP protocol chosen by the caller.  See *VAppIPAssignmentInfo*.  | [optional] 
**PropertyMapping** | [**List&lt;KeyValue&gt;**](KeyValue.md) | The assignment of values to the properties found in the descriptor.  If no value is specified for an option, the default value from the descriptor is used.  | [optional] 
**ResourceMapping** | [**List&lt;OvfResourceMap&gt;**](OvfResourceMap.md) | Deprecated as of vSphere API 5.1.  The resource configuration for the created vApp.  This can be used to distribute a vApp across multiple resource pools (and create linked children).  | [optional] 
**DiskProvisioning** | **string** | An optional disk provisioning.  If set, all the disks in the deployed OVF will have get the same specified disk type (e.g., thin provisioned). The valid values for disk provisioning are: - *monolithicSparse* - *monolithicFlat* - *twoGbMaxExtentSparse* - *twoGbMaxExtentFlat* - *thin* - *thick* - *sparse* - *flat* - *seSparse*    See also *VirtualDiskMode_enum*.  | [optional] 
**InstantiationOst** | [**OvfConsumerOstNode**](OvfConsumerOstNode.md) | The instantiation OST to configure OVF consumers.  This is created by the client from the annotated OST. See *OvfConsumer* for details.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

