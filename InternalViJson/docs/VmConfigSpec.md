# Vcenter.ViJson.OpenApi.Model.VmConfigSpec

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

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

