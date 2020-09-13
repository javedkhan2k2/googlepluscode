import openlocationcode as olc

latitude = 34.537042
longitude = 69.162293

## Converting latitude and longitude to PlusCode
plusCode = olc.encode(latitude, longitude)
print(plusCode)

## Converting PlusCode to latitude and longitude
area = olc.decode(plusCode)
print(area.latitudeCenter)
print(area.longitudeCenter)