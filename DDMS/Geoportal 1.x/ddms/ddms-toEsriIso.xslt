<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" 
  exclude-result-prefixes="rdf dc dct ows dcmiBox"  
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#" 
  xmlns:dc="http://purl.org/dc/elements/1.1/"
  xmlns:dct="http://purl.org/dc/terms/"
  xmlns:ows="http://www.opengis.net/ows"
  xmlns:dcmiBox="http://dublincore.org/documents/2000/07/11/dcmi-box/"
  
  xmlns:ddms="http://metadata.dod.mil/mdr/ns/DDMS/1.4/"
  xmlns:ICISM="urn:us:gov:ic:ism:v2"
  xmlns:ec08="http://www.opengis.net/ec08"
  xmlns:gml="http://www.opengis.net/gml"
>
  <xsl:output indent="yes" method="xml" omit-xml-declaration="no"/>
  
  <xsl:template match="/">
    <xsl:apply-templates mode="root" select="*"/>
  </xsl:template>
  
  <!-- this will match the root of the record -->
  <xsl:template match="*" mode="root">
    <xsl:call-template name="create-esri-iso"/>
  </xsl:template>

  <xsl:template name="ims-content-type-code">   
    <xsl:choose>
      <xsl:when test=". = 'Live Data and Maps'">liveData</xsl:when>
      <xsl:when test=". = 'Downloadable Data'">downloadableData</xsl:when>
      <xsl:when test=". = 'Offline Data'">offlineData</xsl:when>
      <xsl:when test=". = 'Static Map Images'">staticMapImage</xsl:when>
      <xsl:when test=". = 'Other Documents'">document</xsl:when>
      <xsl:when test=". = 'Applications'">application</xsl:when>
      <xsl:when test=". = 'Geographic Services'">geographicService</xsl:when>
      <xsl:when test=". = 'Clearinghouses'">clearinghouse</xsl:when>
      <xsl:when test=". = 'Map Files'">mapFiles</xsl:when>
      <xsl:when test=". = 'Geographic Activities'">geographicActivities</xsl:when>
      <xsl:otherwise>unknown</xsl:otherwise>
    </xsl:choose>
  </xsl:template>
  
  <xsl:template name="esri-content-type-code">    
    <xsl:choose>
      <xsl:when test=". = 'Live Data and Maps'">001</xsl:when>
      <xsl:when test=". = 'Downloadable Data'">002</xsl:when>
      <xsl:when test=". = 'Offline Data'">003</xsl:when>
      <xsl:when test=". = 'Static Map Images'">004</xsl:when>
      <xsl:when test=". = 'Other Documents'">005</xsl:when>
      <xsl:when test=". = 'Applications'">006</xsl:when>
      <xsl:when test=". = 'Geographic Services'">007</xsl:when>
      <xsl:when test=". = 'Clearinghouses'">008</xsl:when>
      <xsl:when test=". = 'Map Files'">009</xsl:when>
      <xsl:when test=". = 'Geographic Activities'">010</xsl:when>
    </xsl:choose>
  </xsl:template>
  
  <!-- convert ISO topic codes to ESRI values -->
  <xsl:template name="topic-code">  
    <xsl:variable name="code">
      <xsl:choose>
        <xsl:when test=". = 'farming'">001</xsl:when>
        <xsl:when test=". = 'biota'">002</xsl:when>
        <xsl:when test=". = 'boundaries'">003</xsl:when>
        <xsl:when test=". = 'climatologyMeteorologyAtmosphere'">004</xsl:when>
        <xsl:when test=". = 'economy'">005</xsl:when>
        <xsl:when test=". = 'elevation'">006</xsl:when>
        <xsl:when test=". = 'environment'">007</xsl:when>
        <xsl:when test=". = 'geoscientificInformation'">008</xsl:when>
        <xsl:when test=". = 'health'">009</xsl:when>
        <xsl:when test=". = 'imageryBaseMapsEarthCover'">010</xsl:when>
        <xsl:when test=". = 'intelligenceMilitary'">011</xsl:when>
        <xsl:when test=". = 'inlandWaters'">012</xsl:when>
        <xsl:when test=". = 'location'">013</xsl:when>
        <xsl:when test=". = 'oceans'">014</xsl:when>
        <xsl:when test=". = 'planningCadastre'">015</xsl:when>
        <xsl:when test=". = 'society'">016</xsl:when>
        <xsl:when test=". = 'structure'">017</xsl:when>
        <xsl:when test=". = 'transportation'">018</xsl:when>
        <xsl:when test=". = 'utilitiesCommunication'">019</xsl:when>
      </xsl:choose>
    </xsl:variable>
    <xsl:if test="string-length($code) &gt; 0">
		<tpCat>
			<TopicCatCd value="{$code}"/>
		</tpCat>	
    </xsl:if>
  </xsl:template>
  
  <!-- create an ESRI-ISO XML document -->
  <xsl:template name="create-esri-iso">
    <metadata>
      <Esri>
        <PublishedDocID><xsl:value-of select="/ddms:Resource/ddms:identifier/@ddms:value"/></PublishedDocID>
        <PublishStatus>Published</PublishStatus>
      </Esri>
      
      <xsl:if test="(count(/ddms:Resource/ddms:subjectCoverage/ddms:Subject/ddms:keyword/@ddms:value) &gt; 0)">
      <distInfo>
        <distributor>
          <distorTran>
            <onLineSrc>
              <orDesc>
                <xsl:for-each select="/ddms:Resource/ddms:subjectCoverage/ddms:Subject/ddms:keyword/@ddms:value">
                  <xsl:call-template name="esri-content-type-code"/>
                </xsl:for-each>
              </orDesc>
            </onLineSrc>
          </distorTran>
        </distributor>
      </distInfo>
      </xsl:if>
      
      <dataIdInfo>
        <idCitation>
          <resTitle>
            <xsl:value-of select="/ddms:Resource/ddms:title"/>
          </resTitle>

		  <!-- creator -->
          <xsl:choose>
          <xsl:when test="(count(/ddms:Resource/ddms:creator/ddms:Person) &gt; 0)">
            <citRespParty>
              <rpIndName><xsl:value-of select="/ddms:Resource/ddms:creator/ddms:Person/ddms:name"/><xsl:text> </xsl:text><xsl:value-of select="/ddms:Resource/ddms:creator/ddms:Person/ddms:surname"/></rpIndName>
              <rpOrgName><xsl:value-of select="/ddms:Resource/ddms:creator/ddms:Person/ddms:affiliation"/></rpOrgName>
              <role><RoleCd value="006"/></role>
              <rpCntInfo>
					<cntAddress>
					  <eMailAdd><xsl:value-of select="/ddms:Resource/ddms:creator/ddms:Person/ddms:email"/></eMailAdd>
					</cntAddress>
				  <cntPhone><xsl:value-of select="/ddms:Resource/ddms:creator/ddms:Person/ddms:phone"/></cntPhone>
              </rpCntInfo>
            </citRespParty>
          </xsl:when>        
          <xsl:when test="(count(/ddms:Resource/ddms:creator/ddms:Organization) &gt; 0)">
            <citRespParty>
              <rpOrgName><xsl:value-of select="/ddms:Resource/ddms:creator/ddms:Organization/ddms:name"/></rpOrgName>
              <role><RoleCd value="006"/></role>
              <rpCntInfo>
					<cntAddress>
					  <eMailAdd><xsl:value-of select="/ddms:Resource/ddms:creator/ddms:Organization/ddms:email"/></eMailAdd>
					</cntAddress>
				  <cntPhone><xsl:value-of select="/ddms:Resource/ddms:creator/ddms:Organization/ddms:phone"/></cntPhone>
              </rpCntInfo>
            </citRespParty>
          </xsl:when>        
		  </xsl:choose>
		  
		  <!-- publisher -->
          <xsl:choose>
          <xsl:when test="(count(/ddms:Resource/ddms:publisher/ddms:Person) &gt; 0)">
            <citRespParty>
              <rpIndName><xsl:value-of select="/ddms:Resource/ddms:publisher/ddms:Person/ddms:name"/><xsl:text> </xsl:text><xsl:value-of select="/ddms:Resource/ddms:creator/ddms:Person/ddms:surname"/></rpIndName>
              <rpOrgName><xsl:value-of select="/ddms:Resource/ddms:publisher/ddms:Person/ddms:affiliation"/></rpOrgName>
              <role><RoleCd value="010"/></role>
              <rpCntInfo>
					<cntAddress>
					  <eMailAdd><xsl:value-of select="/ddms:Resource/ddms:publisher/ddms:Person/ddms:email"/></eMailAdd>
					</cntAddress>
				  <cntPhone><xsl:value-of select="/ddms:Resource/ddms:publisher/ddms:Person/ddms:phone"/></cntPhone>
              </rpCntInfo>
            </citRespParty>
          </xsl:when>        
          <xsl:when test="(count(/ddms:Resource/ddms:publisher/ddms:Organization) &gt; 0)">
            <citRespParty>
              <rpOrgName><xsl:value-of select="/ddms:Resource/ddms:publisher/ddms:Organization/ddms:name"/></rpOrgName>
              <role><RoleCd value="010"/></role>
              <rpCntInfo>
					<cntAddress>
					  <eMailAdd><xsl:value-of select="/ddms:Resource/ddms:publisher/ddms:Organization/ddms:email"/></eMailAdd>
					</cntAddress>
				  <cntPhone><xsl:value-of select="/ddms:Resource/ddms:publisher/ddms:Organization/ddms:phone"/></cntPhone>
              </rpCntInfo>
            </citRespParty>
          </xsl:when>        
		  </xsl:choose>
        </idCitation>
                
        <xsl:if test="(count(//ddms:Resource/ddms:description) &gt; 0)">
          <idAbs>
            <xsl:value-of select="/ddms:Resource/ddms:description"/>
          </idAbs>
        </xsl:if>
        
      <xsl:if test="(count(/ddms:Resource/ddms:subjectCoverage/ddms:Subject/ddms:keyword/@ddms:value) &gt; 0)">
      <descKeys>
			<keyTyp><KeyTypCd value="005"/></keyTyp>
			<xsl:for-each select="/ddms:Resource/ddms:subjectCoverage/ddms:Subject/ddms:keyword/@ddms:value">
				<keyword><xsl:value-of select="." /></keyword>
			</xsl:for-each>
      </descKeys>
      </xsl:if>

      <xsl:if test="(count(/ddms:Resource/ddms:subjectCoverage/ddms:Subject/ddms:keyword/@ddms:value) &gt; 0)">
		<xsl:for-each select="/ddms:Resource/ddms:subjectCoverage/ddms:Subject/ddms:keyword/@ddms:value">
		  <xsl:call-template name="topic-code"/>
		</xsl:for-each>
      </xsl:if>

        <xsl:if test="(count(/ddms:Resource/ddms:geospatialCoverage/ddms:GeospatialExtent/ddms:boundingBox) &gt; 0)">
          <geoBox esriExtentType="decdegrees">
            <exTypeCode>1</exTypeCode>
            <westBL><xsl:value-of select="/ddms:Resource/ddms:geospatialCoverage/ddms:GeospatialExtent/ddms:boundingBox/ddms:WestBL"/></westBL>
            <eastBL><xsl:value-of select="/ddms:Resource/ddms:geospatialCoverage/ddms:GeospatialExtent/ddms:boundingBox/ddms:EastBL"/></eastBL>
            <southBL><xsl:value-of select="/ddms:Resource/ddms:geospatialCoverage/ddms:GeospatialExtent/ddms:boundingBox/ddms:SouthBL"/></southBL>
            <northBL><xsl:value-of select="/ddms:Resource/ddms:geospatialCoverage/ddms:GeospatialExtent/ddms:boundingBox/ddms:NorthBL"/></northBL>
          </geoBox>
        </xsl:if>
        
      </dataIdInfo>
    </metadata>
  </xsl:template>
  
</xsl:stylesheet>
