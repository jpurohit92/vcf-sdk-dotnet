# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersInstalledImagesImageCategories
The Esx.Settings.Clusters.InstalledImages.ImageCategories schema contains (@term fields) describing software image categorized on pre-defined criteria.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsHighestAndWidelyUsedImageEqual** | **bool** | Boolean flag indicating if most widely used image and highest versioned image is same. If this flag is set, it means “mostWidelyUsedImage” and “highestVersionImage” of “imageCategories” will contain same software image as value otherwise it will contain different value.  This property was added in __vSphere API 8.0.3.0__.  if missing or &#x60;null&#x60; or empty means either there was an error fetching software specification of an ESXi host or the hosts in the cluster are ineligible to transition to vLCM. | 
**MostWidelyUsedImage** | [**EsxSettingsClustersInstalledImagesInstalledImage**](EsxSettingsClustersInstalledImagesInstalledImage.md) | This image category contains the software image that is most prevalent among the hosts in the cluster.  This property was added in __vSphere API 8.0.3.0__.  if missing or &#x60;null&#x60; or empty means either there was an error fetching software specification of an ESXi host or the hosts in the cluster are ineligible to transition to vLCM. | [optional] 
**HighestVersionedImage** | [**EsxSettingsClustersInstalledImagesInstalledImage**](EsxSettingsClustersInstalledImagesInstalledImage.md) | This image category contains the software image which has highest ESXi version in the cluster.  This property was added in __vSphere API 8.0.3.0__.  if missing or &#x60;null&#x60; or empty means either there was an error fetching software specification of an ESXi host or the hosts in the cluster are ineligible to transition to vLCM. | [optional] 
**HostImageList** | [**List&lt;EsxSettingsClustersInstalledImagesInstalledImage&gt;**](EsxSettingsClustersInstalledImagesInstalledImage.md) | This list will contain software image running on hosts in the cluster excluding “highestVersionedImage” and “mostWidelyUsedImage”  This property was added in __vSphere API 8.0.3.0__.  if missing or &#x60;null&#x60; or empty means there is no ESXi hosts in the cluster running software specification which is different than the one specified by mostWidelyUsed or highestVersionedImage. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

