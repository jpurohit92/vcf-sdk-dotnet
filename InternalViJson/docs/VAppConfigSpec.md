# Vcenter.ViJson.OpenApi.Model.VAppConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Product** | [**List&lt;VAppProductSpec&gt;**](VAppProductSpec.md) | Information about the product.  Reconfigure privilege: VApp.ApplicationConfig  | [optional] 
**Property** | [**List&lt;VAppPropertySpec&gt;**](VAppPropertySpec.md) | List of properties.  Adding and editing properties requires various privileges depending on which fields are affected. See *VAppPropertyInfo* for details.  Deleting properties requires the privilege VApp.ApplicationConfig.  | [optional] 
**IpAssignment** | [**VAppIPAssignmentInfo**](VAppIPAssignmentInfo.md) | IP assignment policy and DHCP support configuration.  Reconfigure privilege: See *VAppIPAssignmentInfo*  | [optional] 
**Eula** | **List&lt;string&gt;** | End User Licenses Agreements.  If this list is set, it replaces all exiting licenses. An empty list will not make any changes to installed licenses. A list with a single element {\&quot;\&quot;} will remove all licenses and leave an empty list.  Reconfigure privilege: VApp.ApplicationConfig  | [optional] 
**OvfSection** | [**List&lt;VAppOvfSectionSpec&gt;**](VAppOvfSectionSpec.md) | List of uninterpreted OVF meta-data sections.  Reconfigure privilege: VApp.ApplicationConfig  | [optional] 
**OvfEnvironmentTransport** | **List&lt;string&gt;** | List the transports to use for properties.  Supported values are: iso and com.vmware.guestInfo.  If this list is set, it replaces all exiting entries. An empty list will not make any changes. A list with a single element {\&quot;\&quot;} will clear the list of transports.  Reconfigure privilege: VApp.ApplicationConfig  | [optional] 
**InstallBootRequired** | **bool** | If this is on a VirtualMachine object, it specifies whether the VM needs an initial boot before the deployment is complete.  If this is on a vApp object, it indicates than one or more VMs needs an initial reboot. This flag is automatically reset once the reboot has happened.  Reconfigure privilege: VApp.ApplicationConfig  | [optional] 
**InstallBootStopDelay** | **int** | Specifies the delay in seconds to wait for the VM to power off after the initial boot (used only if installBootRequired is true).  A value of 0 means wait forever.  Reconfigure privilege: VApp.ApplicationConfig  | [optional] 
**EntityConfig** | [**List&lt;VAppEntityConfigInfo&gt;**](VAppEntityConfigInfo.md) | Configuration of sub-entities (virtual machine or vApp container).  Reconfigure privilege: See EntityConfigInfo  | [optional] 
**Annotation** | **string** | Description for the vApp.  Reconfigure privilege: VApp.Rename.  | [optional] 
**InstanceUuid** | **string** | vCenter-specific 128-bit UUID of a vApp, represented as a hexadecimal string.  This identifier is used by vCenter to uniquely identify all vApp instances in the Virtual Infrastructure environment.  Normally, this property is not set by a client, allowing the Virtual Infrastructure environment to assign or change it when VirtualCenter detects an identifier conflict between vApps.  Reconfigure privilege: VApp.ApplicationConfig  | [optional] 
**ManagedBy** | [**ManagedByInfo**](ManagedByInfo.md) | Specifies that this vApp is managed by a VC Extension.  This information is primarily used in the Client to show a custom icon for managed vApps, and a description of the function of the vApp. If no extension can be found with the extension key in the *managedBy* object, or the type is not found in the *managedEntityInfo* list of the extension, the default vApp icon is used, and no description is shown.  Reconfigure privilege: VApp.ApplicationConfig  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

