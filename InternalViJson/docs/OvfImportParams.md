# Vcenter.ViJson.OpenApi.Model.OvfImportParams

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityName** | **string** | The name to set on the entity (more precisely, on the top-level vApp or VM of the entity) as it appears in VI.  If empty, the product name is obtained from the ProductSection of the descriptor. If that name is not specified, the ovf:id of the top-level entity is used.  | 
**HostSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host to validate the OVF descriptor against, if it cannot be deduced from the resource pool.  The privilege System.Read is required on the host.  Refers instance of *HostSystem*.  | [optional] 
**NetworkMapping** | [**List&lt;OvfNetworkMapping&gt;**](OvfNetworkMapping.md) | The mapping of network identifiers from the descriptor to networks in the VI infrastructure.  The privilege Network.Assign is required on all networks in the list.  | [optional] 
**IpAllocationPolicy** | **string** | The IP allocation policy chosen by the caller.  See *VAppIPAssignmentInfo*.  | [optional] 
**IpProtocol** | **string** | The IP protocol chosen by the caller.  See *VAppIPAssignmentInfo*.  | [optional] 
**PropertyMapping** | [**List&lt;KeyValue&gt;**](KeyValue.md) | The assignment of values to the properties found in the descriptor.  If no value is specified for an option, the default value from the descriptor is used.  | [optional] 
**ResourceMapping** | [**List&lt;OvfResourceMap&gt;**](OvfResourceMap.md) | Deprecated as of vSphere API 5.1.  The resource configuration for the created vApp.  This can be used to distribute a vApp across multiple resource pools (and create linked children).  | [optional] 
**DiskProvisioning** | **string** | An optional disk provisioning.  If set, all the disks in the deployed OVF will have get the same specified disk type (e.g., thin provisioned). The valid values for disk provisioning are: - *monolithicSparse* - *monolithicFlat* - *twoGbMaxExtentSparse* - *twoGbMaxExtentFlat* - *thin* - *thick* - *sparse* - *flat* - *seSparse*    See also *VirtualDiskMode_enum*.  | [optional] 
**InstantiationOst** | [**OvfConsumerOstNode**](OvfConsumerOstNode.md) | The instantiation OST to configure OVF consumers.  This is created by the client from the annotated OST. See *OvfConsumer* for details.  | [optional] 
**PushMode** | **bool** | Use Push mode for transferring VM files to ESX.  Push mode transfers files from client to ESXi, whereas in Pull mode ESX \&quot;pulls\&quot; the files directly from source. This flag only applies to vCenter as ESXi can only pull directly if *OvfManager.DeployVm_Task* is invoked on ESX itself. See (@link vim.HttpNfcLease#pullFromUrls) for more on Pull mode. The default/Default: false  | [optional] 
**SignatureRequired** | **bool** | Require that the OVF package has a signed certificate and manifest and both match.  See also manifest validation. Default is false.  | [optional] 
**SkipManifestCheck** | **bool** | If a manifest file is present in the OVF package the format is checked.  Also all file SHA entries are validated against SHA of read files. If value is true and manifest file is present a warning is generated. Default is false.  | [optional] 
**PowerOn** | **bool** | Whether to power on the deployed entity.  Note for ESX and Virtual Machine deployment: In order to customize GuestOS on a deployed Virtual Machine we require that the powerOn flag must be true. GuestOS customization happens after VM is powered On and then reconfigured. vCenter does not require a powerOn and reconfigure to customize GuestOS as it stores all OVF properties as VApp properties and pushes them to GuestOS upon powerOn for consumption. Default is false.  | [optional] 
**CustomHttpHeaders** | [**List&lt;KeyValue&gt;**](KeyValue.md) | For the case when remote server requires authentication or any other type of custom HTTP headers be provided with the request.  | [optional] 
**SourceCertificate** | **string** | Optionally used for source validation.  The source server certificate in PEM format.  | [optional] 
**DatastoreMappings** | [**List&lt;OvfDatastoreMapping&gt;**](OvfDatastoreMapping.md) | The optional datastore mapping(s).  | [optional] 
**VmProfile** | **string** | The optional Storage Profile Id for VM&#39;s home.  | [optional] 
**DiskProfiles** | [**List&lt;OvfStorageProfileMapping&gt;**](OvfStorageProfileMapping.md) | The optional Storage Profile mapping(s).  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

