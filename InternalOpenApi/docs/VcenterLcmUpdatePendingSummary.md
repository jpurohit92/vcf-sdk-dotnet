# Vcenter.Automation.OpenApi.Model.VcenterLcmUpdatePendingSummary
The Vcenter.Lcm.Update.Pending.Summary schema contains basic information about the vCenter patch/update/upgrade

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PendingUpdate** | **string** | Identifier of the given vSphere update  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.lcm.update.pending&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.lcm.update.pending&#x60;. | 
**VarVersion** | **string** | Version of the vSphere update or patch | 
**ReleaseDate** | **DateTime** | Release date of the vSphere update or patch | 
**Severity** | **string** | Severity of the issues fixed in the vSphere update or patch  Possible values:   - &#x60;CRITICAL&#x60;: Vulnerabilities that can be exploited by an unauthenticated attacker from the Internet or those that break the guest/host Operating System isolation.   - &#x60;IMPORTANT&#x60;: Vulnerabilities that are not rated critical but whose exploitation results in the complete compromise of confidentiality and/or integrity of user data and/or processing resources through user assistance or by authenticated attackers.   - &#x60;MODERATE&#x60;: Vulnerabilities where the ability to exploit is mitigated to a significant degree by configuration or difficulty of exploitation, but in certain deployment scenarios could still lead to the compromise of confidentiality, integrity, or availability of user data and/or processing resources.   - &#x60;LOW&#x60;: All other issues that may or maynot have a security impact. Vulnerabilities where exploitation is believed to be extremely difficult, or where successful exploitation would have minimal impact.   For more information see: *Vcenter.Lcm.Update.Pending.SeverityType*. | 
**Build** | **string** | Build number of the vCenter Release | 
**UpdateType** | **string** | Type of the Release based on the current vCenter version  Possible values:   - &#x60;PATCH&#x60;: Fixes bugs/vulnerabilities, doesn&#39;t change functionality   - &#x60;UPDATE&#x60;: Changes product functionality   - &#x60;UPGRADE&#x60;: Introduces new features, significantly changes product functionality   For more information see: *Vcenter.Lcm.Update.Pending.UpdateType*. | 
**Category** | **string** | Category of the release based on features bundled on top of previous release  Possible values:   - &#x60;SECURITY&#x60;: Fixes vulnerabilities, doesn&#39;t change functionality   - &#x60;FIX&#x60;: Fixes bugs/vulnerabilities, doesn&#39;t change functionality   - &#x60;UPDATE&#x60;: Changes product functionality   - &#x60;UPGRADE&#x60;: Introduces new features, significantly changes product functionality   For more information see: *Vcenter.Lcm.Update.Pending.Category*. | 
**RebootRequired** | **bool** | Flag to suggest a reboot after the release is applied | 
**QuickPatch** | **bool** | Flag indicating whether the incoming patch is a quick patch.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; the patch is not a quick patch | [optional] 
**WorkloadManagementImpact** | **bool** | Flag indicating if there is an impact to workload management. False: The following Workload Management API-Driven Operations are fully operational and will not be disrupted by this update. VM workload provisioning, VM CRUD Operations Kubernetes workload provisioning, Kubernetes CRUD Operations Compute and Storage Scaling Continuous log collection and forwarding to Ops for monitoring True: Workload management will be disrupted for a given downtime.  This property was added in __vSphere API 9.1.0.0__.  workloadManagementImpact If missing or &#x60;null&#x60; the patch is not a quick patch | [optional] 
**ExecuteUrl** | **string** | VAMI or ISO URL for update or upgrade execute phase redirection | 
**ReleaseNotes** | **List&lt;string&gt;** | List of URI pointing to patch or update release notes | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

