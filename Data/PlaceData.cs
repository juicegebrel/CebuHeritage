using CebuHeritage.Models;

namespace CebuHeritage.Data;

/// <summary>
/// Seed content for the app. Replace or extend this with a database or JSON file later.
/// Travel times and accommodation details change, so verify them before booking a trip.
/// </summary>
public static class PlaceData
{
    public static IReadOnlyList<Place> Build() => new List<Place>
    {
        // ───────────────────────── METRO CEBU ─────────────────────────
        new()
        {
            Slug = "cebu-city",
            Name = "Cebu City",
            Kind = "City",
            Region = "Metro Cebu",
            Gradient = "from-orange-500 via-rose-600 to-purple-800",
            ImageUrl = "/images/cebu-city.jpg",
            Tagline = "The Queen City of the South, where Spanish colonial history in the Philippines began. asdngjnasdjngljasndgjnasdjlng lasndglnasldgnakl sdngklansdklgnas lkdnglsndglknsdklg",
            Overview = "Cebu City is the oldest city in the Philippines and the capital of the province. Magellan's arrival, the first Spanish settlement and the enduring devotion to the Santo Niño all happened here, and you can still walk between the places where they took place. Today it is also a busy commercial centre, so old churches and forts sit a short ride from malls and business districts.",
            GettingThere = "Served by Mactan-Cebu International Airport (about 30–60 minutes by road, depending on traffic). Taxis, ride-hailing and jeepneys cover the city.",
            FestivalName = "Sinulog Festival",
            FestivalNote = "Held every third Sunday of January in honour of the Santo Niño. Expect street dancing, a grand parade and crowds, so book rooms months ahead.",
            KnownFor = new() { "Magellan's Cross", "Santo Niño devotion", "Lechon", "Sinulog" },
            History = new()
            {
                new("1521", "Ferdinand Magellan arrives. Rajah Humabon and his people are baptised, and a cross is planted that later becomes Magellan's Cross."),
                new("1565", "Miguel López de Legazpi founds the first Spanish settlement in the islands, Villa del Santísimo Nombre de Jesús. Fort San Pedro begins as a wooden stockade."),
                new("1738", "Fort San Pedro is rebuilt in stone to defend against raiders."),
                new("1937", "Cebu is chartered as a city."),
                new("1945", "The city is liberated after the Second World War and begins rebuilding."),
            },
            Culture = new()
            {
                new("🙏", "Devotion to the Santo Niño", "The image of the Child Jesus is the centre of Cebuano faith. Pilgrims light candles and dance the sinulog outside the Basilica all year, not only in January."),
                new("🍖", "Lechon and puso", "Cebu's roast pig is famous across the country. It is traditionally eaten with puso, rice cooked in woven coconut-leaf pouches."),
                new("🗣️", "Cebuano language", "Cebuano (Bisaya) is the everyday language and one of the most widely spoken in the Philippines."),
                new("🏠", "Ancestral houses", "Merchant families built grand homes in the Parian district. Several are open as museums and show how wealthy Cebuanos lived under Spanish and American rule."),
            },
            Attractions = new()
            {
                new("Magellan's Cross", "Landmark", "✝️", "A cross housed in a small chapel, marking the 1521 baptisms. The painted ceiling above it shows the scene."),
                new("Basilica Minore del Santo Niño", "Church", "⛪", "Home of the Santo Niño image and widely described as the oldest Roman Catholic church in the country."),
                new("Fort San Pedro", "Fortress", "🏰", "A triangular stone fort by the port, with walls you can walk and a small museum inside."),
                new("Casa Gorordo Museum", "Museum", "🏛️", "A restored 19th-century home that shows the life of a prominent Cebuano family."),
                new("Yap–San Diego Ancestral House", "Heritage house", "🏠", "One of the oldest surviving residences in the country, dating to the late 1600s."),
                new("Taoist Temple", "Temple", "🏯", "A hillside temple in Beverly Hills, reflecting the city's long-standing Chinese community."),
                new("Sirao Pictorial Garden", "Highland garden", "🌸", "A flower garden in the hills above the city, popular for sunrise and cool weather."),
                new("Colon Street and Carbon Market", "Street and market", "🛍️", "Colon is often called the oldest street in the country. Carbon Market is the place for produce, dried fish and everyday Cebu life."),
            },
            Stays = new()
            {
                new("Radisson Blu Cebu", "Upscale city hotel", "Modern rooms close to the waterfront and the main sightseeing area."),
                new("Marco Polo Plaza Cebu", "Hilltop hotel", "Set in the hills with wide views over the city and the Mactan Channel."),
                new("Waterfront Cebu City Hotel & Casino", "Large city hotel", "A long-running hotel in the Lahug district with plenty of dining options nearby."),
                new("Montebello Villa Hotel", "Garden hotel", "A calmer, garden-style option with a relaxed, residential feel."),
            },
        },

        new()
        {
            Slug = "lapu-lapu-city",
            Name = "Lapu-Lapu City",
            Kind = "City",
            Region = "Metro Cebu",
            Gradient = "from-sky-500 via-cyan-600 to-blue-800",
            ImageUrl = "/images/lapu-lapu-city.png",
            Tagline = "Mactan Island, where Lapulapu's warriors stood against Magellan.",
            Overview = "Lapu-Lapu City occupies much of Mactan Island, linked to Cebu City by bridges. It is the site of the 1521 Battle of Mactan, the home of the region's international airport, and the centre of Cebu's beach-resort industry. History visitors come for the shrines, while most holidaymakers come for the resorts and island-hopping trips.",
            GettingThere = "Mactan-Cebu International Airport is within the city, so many visitors start here. The Marcelo Fernan and Mactan–Mandaue bridges connect it to the mainland.",
            FestivalName = "Kadaugan sa Mactan",
            FestivalNote = "A yearly commemoration around April 27 that re-enacts the Battle of Mactan and honours Lapulapu's victory.",
            KnownFor = new() { "Battle of Mactan", "Beach resorts", "Island hopping", "Airport gateway" },
            History = new()
            {
                new("April 27, 1521", "Lapulapu and his warriors defeat Magellan's forces at the Battle of Mactan. Magellan is killed, and Lapulapu is remembered as an early Filipino resistance leader."),
                new("Spanish era", "The settlement on Mactan, then known as Opon, becomes part of the colonial town network of Cebu."),
                new("1961", "Opon is chartered as a city and renamed Lapu-Lapu City in honour of its hero."),
                new("Late 20th century", "Resorts open along the coast and Mactan becomes the main beach destination near Cebu City."),
            },
            Culture = new()
            {
                new("⚔️", "Remembering Lapulapu", "The hero is a source of local pride. His statue, shrines and the annual re-enactment keep the story visible for residents and visitors alike."),
                new("🎸", "Guitar-making tradition", "Mactan Island has long been associated with handmade guitars and other string instruments, a craft passed down through families."),
                new("🐟", "Seafood and dried fish", "Fishing remains part of island life. Fresh catches and dried fish are widely sold, and seafood restaurants are a big draw."),
            },
            Attractions = new()
            {
                new("Mactan Shrine (Liberty Shrine)", "Historic site", "🗿", "A monument to Lapulapu at Punta Engaño, with a large statue and memorial grounds."),
                new("Magellan Shrine", "Historic site", "⚓", "Marks the spot traditionally linked to Magellan's death during the 1521 battle."),
                new("Hilutungan and Nalusuan Islands", "Marine sanctuary", "🐠", "Small islands close to shore with protected reefs for snorkelling and diving."),
                new("Olango Island Wildlife Sanctuary", "Birdwatching", "🦆", "Mudflats and mangroves recognised as an important stop for migratory birds."),
                new("Resort beaches of Punta Engaño", "Beach", "🏖️", "The coast near the shrines is lined with resorts that offer day passes and water sports."),
            },
            Stays = new()
            {
                new("Shangri-La Mactan", "Luxury beach resort", "A large resort on its own stretch of shoreline with multiple pools and restaurants."),
                new("Plantation Bay Resort and Spa", "Family resort", "Known for its lagoon-style pools and water attractions, popular with families."),
                new("Crimson Resort and Spa Mactan", "Beachfront resort", "A modern beachfront property with resort-style facilities."),
                new("Mövenpick Hotel Mactan Island Cebu", "Resort hotel", "Close to the airport and the beach, convenient for short stays."),
            },
        },

        // ───────────────────────── SOUTH CEBU ─────────────────────────
        new()
        {
            Slug = "carcar-city",
            Name = "Carcar City",
            Kind = "City",
            Region = "South Cebu",
            Gradient = "from-amber-500 via-orange-600 to-red-800",
            ImageUrl = "/images/carcar-city.jpg",
            Tagline = "A heritage town of old houses, a landmark church and some of the best chicharon in Cebu.",
            Overview = "Carcar is the first major heritage stop south of Cebu City. Its centre is a compact grid of Spanish-era houses, a rotunda and a busy public market. It is a favourite day trip for food and architecture, and many travellers pair it with Argao and the south.",
            GettingThere = "Roughly 40 km from Cebu City, a ride of about 1 to 1.5 hours by bus from the South Bus Terminal.",
            FestivalName = "Fiesta of Santa Catalina",
            FestivalNote = "The town celebrates its patron saint, St. Catherine of Alexandria, around November 25.",
            KnownFor = new() { "Heritage houses", "Chicharon", "Ampao", "Santa Catalina Church" },
            History = new()
            {
                new("Late 1500s", "Carcar takes shape as a Spanish colonial settlement in the south of the island and grows around its church."),
                new("19th century", "Prosperity from trade and farming allows local families to build the stone-and-wood houses that still line the old streets."),
                new("2007", "Carcar becomes a component city."),
            },
            Culture = new()
            {
                new("🐖", "Chicharon capital", "Carcar's crackling pork rinds are a signature souvenir. Stalls at the market sell them by the bagful."),
                new("🍬", "Ampao and sweets", "Puffed-rice sweets (ampao) and other local snacks are bought for the road home."),
                new("🏡", "Living heritage", "Many old houses are still family homes. The streets are meant to be walked slowly and appreciated from outside."),
            },
            Attractions = new()
            {
                new("Carcar Heritage Zone", "Heritage walk", "🏘️", "A stretch of old houses on and around Rizal Avenue showing late Spanish and early American styles."),
                new("Carcar Rotunda", "Landmark", "⭕", "A round plaza at the heart of town that anchors the old streets."),
                new("Santa Catalina de Alejandria Parish Church", "Church", "⛪", "The town's main church, beside the plaza and central to local festivals."),
                new("Carcar Public Market", "Food", "🥓", "The best-known place to buy chicharon, ampao and other southern Cebu specialities."),
            },
            Stays = new(),
            StayNote = "Most visitors treat Carcar as a day trip. Nearby overnight options are limited, so many travellers stay in Cebu City or continue south to Argao.",
        },

        new()
        {
            Slug = "argao",
            Name = "Argao",
            Kind = "Municipality",
            Region = "South Cebu",
            Gradient = "from-yellow-500 via-amber-600 to-stone-800",
            ImageUrl = "/images/argao.jpg",
            Tagline = "A historic southern town famous for its torta and its grand church.",
            Overview = "Argao is one of the larger towns on Cebu's east coast, with a stone church, a lively market and a reputation for baked goods. It makes a natural overnight stop between Cebu City and the far south.",
            GettingThere = "About 65 km from Cebu City, around 2 hours by bus from the South Bus Terminal.",
            FestivalName = "Argao Fiesta",
            FestivalNote = "The town honours its patron, St. Michael the Archangel, around September 29.",
            KnownFor = new() { "Torta", "San Miguel Church", "Mount Lantoy", "Heritage houses" },
            History = new()
            {
                new("Early 1600s", "Argao grows as a Spanish colonial town on the eastern coast of Cebu."),
                new("Late 18th to early 19th century", "The stone Church of St. Michael the Archangel is built, becoming the town's defining landmark."),
                new("Today", "Argao remains a regional centre for the southern towns, with its heritage core largely intact."),
            },
            Culture = new()
            {
                new("🎂", "Torta Argao", "A soft sponge cake sold in bakeries around town. It is the most popular pasalubong (gift to bring home) from Argao."),
                new("⛪", "Church-centred life", "The parish church and plaza are where fiestas, processions and Sunday gatherings take place."),
                new("🌄", "Mountain and coast", "Argao sits between mountains and sea, which shapes local farming, fishing and weekend leisure."),
            },
            Attractions = new()
            {
                new("St. Michael the Archangel Parish Church", "Church", "⛪", "A large stone church from the Spanish era with a carved facade and a spacious interior."),
                new("Mount Lantoy", "Nature", "⛰️", "A hill with park areas and viewpoints that look across the town toward the Bohol Strait."),
                new("Argao town centre and market", "Food and culture", "🥮", "Try torta and local snacks around the plaza and market streets."),
                new("Old houses of Argao", "Heritage walk", "🏠", "Several older residences near the plaza are worth a slow walk around the centre."),
            },
            Stays = new()
            {
                new("Seaside resorts along the Argao coast", "Area guide", "Small beach resorts and inns sit along the shore north and south of the town. Compare current reviews and availability before booking."),
                new("Guesthouses near the town centre", "Area guide", "Simple lodging close to the church and market is handy if you want to explore on foot."),
            },
        },

        new()
        {
            Slug = "boljoon",
            Name = "Boljoon",
            Kind = "Municipality",
            Region = "South Cebu",
            Gradient = "from-stone-500 via-amber-700 to-stone-900",
            ImageUrl = "/images/boljoon.jpg",
            Tagline = "A quiet coastal town built around one of Cebu's best-preserved churches.",
            Overview = "Boljoon is small, but its church complex is among the most celebrated heritage sites in the province. The stone church, convent and museum sit above the sea and give a clear picture of how Spanish colonial towns were planned and defended.",
            GettingThere = "About 3 hours from Cebu City by road. Most visitors stop here on a drive toward Oslob.",
            KnownFor = new() { "Patrocinio de Maria Santisima Church", "Heritage museum", "Coastal watchtowers" },
            History = new()
            {
                new("Late 1500s", "Boljoon begins as a Spanish-era mission settlement on the southeastern coast."),
                new("Late 18th century", "The Church of Patrocinio de Maria Santisima is built from coral stone and is later recognised by the Philippine government as an important heritage site."),
                new("Colonial period", "Coastal watchtowers are raised along the shoreline to warn of raiders approaching by sea."),
            },
            Culture = new()
            {
                new("🪨", "Coral stone architecture", "The church is built of local stone, showing the craftsmanship and materials of Spanish-era Cebu."),
                new("🏺", "Parish museum", "The church complex houses a museum of religious objects and local artefacts."),
                new("🌊", "Fishing community", "Boljoon remains a coastal town with a slow rhythm. Fishing and small-scale farming still shape daily life."),
            },
            Attractions = new()
            {
                new("Patrocinio de Maria Santisima Parish Church", "Church", "⛪", "A heritage church with a stone facade, a bell tower and a quiet courtyard above the sea."),
                new("Boljoon Parish Museum", "Museum", "🏺", "Exhibits of religious art and artefacts from the town's history."),
                new("Coastal watchtower", "Historic site", "🗼", "A reminder of the raids that once threatened Cebu's coastal towns."),
            },
            Stays = new(),
            StayNote = "Boljoon has few places to stay. Most travellers sleep in Oslob or Dalaguete and visit the church during the day.",
        },

        new()
        {
            Slug = "oslob",
            Name = "Oslob",
            Kind = "Municipality",
            Region = "South Cebu",
            Gradient = "from-cyan-500 via-teal-600 to-blue-900",
            ImageUrl = "/images/oslob.jpg",
            Tagline = "Whale sharks, waterfalls and a sandbar island at the southern tip of Cebu.",
            Overview = "Oslob became one of the country's best-known tourist towns after whale-shark watching began off the village of Tan-awan. Beyond the whale sharks, the town has waterfalls, a historic coastline and Sumilon Island, so it rewards a longer stay.",
            GettingThere = "Around 115 km from Cebu City, a 3 to 4 hour journey by bus or private car from the South Bus Terminal.",
            KnownFor = new() { "Whale shark watching", "Tumalog Falls", "Sumilon Island", "Spanish-era watchtowers" },
            History = new()
            {
                new("Spanish era", "Oslob develops as a coastal town in southeastern Cebu and builds watchtowers to guard against raiders."),
                new("Late 20th century", "Fishing and farming remain the backbone of the local economy."),
                new("2010s", "Whale-shark encounters turn Oslob into a major tourism destination and transform the local economy."),
            },
            Culture = new()
            {
                new("🎣", "Fishing heritage", "Oslob's fishing families have lived beside these waters for generations."),
                new("🌍", "Tourism and responsibility", "Whale-shark watching in Oslob involves feeding, which some conservation groups criticise. Consider your choices and ask operators about their practices before you book."),
                new("🏖️", "Island life", "Sumilon Island and its sandbar are part of the local identity and a popular stop on day trips."),
            },
            Attractions = new()
            {
                new("Tan-awan whale shark watching", "Wildlife", "🦈", "Boat trips to see whale sharks close to shore. Early morning sessions are quietest."),
                new("Tumalog Falls", "Waterfall", "💧", "A thin, tall waterfall that fans out over a rock face into a swimming pool."),
                new("Sumilon Island", "Island", "🏝️", "A small island known for its sandbar that appears and disappears with the tide."),
                new("Oslob parish church and watchtower", "Heritage", "🗼", "A Spanish-era church complex with a coastal watchtower nearby."),
            },
            Stays = new()
            {
                new("Sumilon Bluewater Island Resort", "Island resort", "A beach resort on Sumilon Island, suited to a quiet escape away from the mainland."),
                new("Beachfront resorts around Tan-awan", "Area guide", "Many small resorts and guesthouses sit close to the whale-shark area, handy for early-morning tours."),
            },
        },

        new()
        {
            Slug = "dalaguete",
            Name = "Dalaguete",
            Kind = "Municipality",
            Region = "South Cebu",
            Gradient = "from-green-500 via-emerald-600 to-teal-900",
            ImageUrl = "/images/dalaguete.jpg",
            Tagline = "Cool highlands, farm terraces and Osmeña Peak.",
            Overview = "Dalaguete reaches from the sea up into Cebu's central mountains. The highland community of Mantalongon is known for vegetable farming and a cooler climate, and Osmeña Peak gives the best mountain views on the island.",
            GettingThere = "Around 3 hours from Cebu City by road. The highlands are reached by habal-habal (motorcycle taxi) or a private car from the main road.",
            KnownFor = new() { "Osmeña Peak", "Mantalongon highlands", "Vegetable farming", "Cool climate" },
            History = new()
            {
                new("Spanish era", "Dalaguete is established on the southeastern coast of Cebu and grows around its parish church."),
                new("Highland settlement", "Farmers settle in the Mantalongon area and cultivate vegetables that supply markets across the province."),
                new("Recent decades", "Hiking and weekend travel make Osmeña Peak a regular stop for visitors."),
            },
            Culture = new()
            {
                new("🥬", "Highland farming", "Terraced farms supply vegetables to Cebu's markets, and the farming community shapes the region's food."),
                new("🌤️", "Cool-weather escapes", "The highlands are noticeably cooler than the coast, which makes them a popular break from the heat."),
                new("⛪", "Coastal heritage", "The old town on the shore keeps its parish church and a slower, traditional rhythm."),
            },
            Attractions = new()
            {
                new("Osmeña Peak", "Mountain viewpoint", "🏔️", "Commonly cited as the highest point in Cebu, with a short climb and a jagged ridge with wide views."),
                new("Mantalongon highlands", "Farming country", "🌱", "Cool hills, vegetable terraces and roadside produce stalls."),
                new("Dalaguete town and parish church", "Heritage", "⛪", "The old town on the coast with its church and plaza."),
            },
            Stays = new()
            {
                new("Highland homestays and camps near Osmeña Peak", "Area guide", "Simple lodges, camps and homestays let you catch the sunrise from the peak. Check current availability and road access."),
                new("Seaside stays in the town", "Area guide", "Small resorts on the coast offer a base for exploring both the shore and the hills."),
            },
        },

        // ───────────────────────── SOUTHWEST CEBU ─────────────────────────
        new()
        {
            Slug = "badian",
            Name = "Badian",
            Kind = "Municipality",
            Region = "Southwest Cebu",
            Gradient = "from-teal-400 via-emerald-500 to-cyan-800",
            ImageUrl = "/images/badian.jpg",
            Tagline = "Home of Kawasan Falls and the canyoneering route that made it famous.",
            Overview = "Badian lies on Cebu's southwest coast, where mountain rivers drop to the sea. Its biggest draw is Kawasan Falls in Matutinao, a turquoise multi-level waterfall, and the canyoneering trips that run through the gorge above it.",
            GettingThere = "Roughly 3 hours from Cebu City by bus to Badian town, then a short ride to Matutinao for the falls.",
            KnownFor = new() { "Kawasan Falls", "Canyoneering", "Beaches", "Mountain rivers" },
            History = new()
            {
                new("Spanish era", "Badian develops as a farming and fishing town on the southwestern coast."),
                new("Late 20th century", "Local guides begin leading visitors through the river gorges."),
                new("Recent decades", "Kawasan Falls and canyoneering turn Badian into one of Cebu's most visited adventure destinations."),
            },
            Culture = new()
            {
                new("🧗", "Guide-led adventure", "Local guides run the canyoneering routes and know the river conditions. Hiring them supports community livelihoods and keeps trips safer."),
                new("🌿", "River communities", "Villages around the falls depend on the river for farming, fishing and tourism."),
                new("🐚", "Fishing coast", "Along the shoreline, small fishing villages still sell their catch."),
            },
            Attractions = new()
            {
                new("Kawasan Falls", "Waterfall", "🌊", "A three-tiered waterfall with vivid turquoise pools, ideal for swimming and bamboo rafting."),
                new("Canyoneering in Matutinao", "Adventure", "🧗", "A guided trip that combines walking, cliff jumps and river swimming through the gorge."),
                new("Lambug Beach", "Beach", "🏖️", "A long stretch of white sand along the coast."),
            },
            Stays = new()
            {
                new("Badian Island Wellness Resort", "Island resort", "A resort on Badian Island, suited to a quiet, wellness-focused stay."),
                new("Riverside and coastal guesthouses near Matutinao", "Area guide", "Budget cottages and inns near the falls let you start the canyoneering route early."),
            },
        },

        new()
        {
            Slug = "moalboal",
            Name = "Moalboal",
            Kind = "Municipality",
            Region = "Southwest Cebu",
            Gradient = "from-blue-500 via-cyan-600 to-indigo-900",
            ImageUrl = "/images/moalboal.jpg",
            Tagline = "Sardine runs and reef diving just metres from the shore.",
            Overview = "Moalboal is one of the Philippines' best-known dive and snorkel destinations. A huge school of sardines gathers close to Panagsama Beach, and the reef drop-off starts almost at the waterline. The town also has a relaxed travel scene with cafés, dive shops and sunset bars.",
            GettingThere = "About 3 hours from Cebu City by bus from the South Bus Terminal, then a short tricycle ride to Panagsama Beach.",
            KnownFor = new() { "Sardine run", "Pescador Island", "Diving", "Panagsama Beach" },
            History = new()
            {
                new("Spanish era", "Moalboal grows as a farming and fishing town on the southwestern coast."),
                new("Late 20th century", "Divers discover the nearby reefs and a small dive-tourism community begins to form at Panagsama."),
                new("Today", "The sardine run and turtle sightings keep Moalboal on the global dive map."),
            },
            Culture = new()
            {
                new("🤿", "Dive culture", "Dive shops, instructors and travellers shape Panagsama's character, and the area is built for early starts and evenings by the sea."),
                new("🌅", "Sunset gatherings", "Evenings are spent at beachfront bars and restaurants, with live music in the busier months."),
                new("🪸", "Reef protection", "Local rules protect marine sanctuaries. Please do not touch or stand on the coral and avoid sunscreen that harms reefs."),
            },
            Attractions = new()
            {
                new("Panagsama Beach sardine run", "Snorkel and dive", "🐟", "Millions of sardines move in a single shifting ball close to the shore. Snorkellers can swim out from the beach."),
                new("Pescador Island", "Island and reef", "🏝️", "A small island with a marine sanctuary and a famous tunnel dive."),
                new("White Beach (Basdiot)", "Beach", "🏖️", "A wide sandy beach just north of Panagsama, quieter than the dive strip."),
            },
            Stays = new()
            {
                new("Kasai Village Dive Resort", "Dive resort", "A dive-focused resort on the Panagsama strip with easy access to the reef."),
                new("Dolphin House Resort", "Beachfront resort", "A well-known beachfront stay with simple rooms close to the sardine run."),
                new("Panagsama beachfront guesthouses", "Area guide", "Budget rooms line the beach, close to restaurants and dive shops."),
            },
        },

        // ───────────────────────── NORTH CEBU & ISLANDS ─────────────────────────
        new()
        {
            Slug = "daanbantayan-malapascua",
            Name = "Daanbantayan and Malapascua",
            Kind = "Municipality",
            Region = "North Cebu & Islands",
            Gradient = "from-indigo-500 via-blue-600 to-slate-900",
            ImageUrl = "/images/malapascua.jpg",
            Tagline = "The northern tip of Cebu, and the island where thresher sharks come at dawn.",
            Overview = "Daanbantayan sits at the northern tip of the island. Malapascua, a small island that belongs to the municipality, is a world-renowned dive spot for thresher sharks, and the wider area has reefs, wrecks and white beaches.",
            GettingThere = "Around 4 hours by road from Cebu City to Maya Port in Daanbantayan, followed by a 30 minute boat to Malapascua.",
            KnownFor = new() { "Thresher sharks", "Monad Shoal", "Bounty Beach", "Gato Island" },
            History = new()
            {
                new("Spanish era", "Daanbantayan is established on the northern coast. Its name is commonly read as old lookout, from daan (old) and bantay (watch)."),
                new("Late 20th century", "Divers begin to report regular thresher shark sightings at Monad Shoal near Malapascua."),
                new("Today", "Malapascua is a leading destination for thresher shark diving, with a tourism economy built around the sea."),
            },
            Culture = new()
            {
                new("🌅", "Dawn dives", "Thresher shark dives leave before sunrise, and the island's rhythm follows the dive schedule."),
                new("🏝️", "Island life", "There are no cars on Malapascua. People get around on foot, by motorbike or by boat, which gives it a slow, small-community feel."),
                new("🎄", "A name with a story", "The island's name is often traced to the Spanish mala pascua, a bad Christmas, and local retellings keep the story alive."),
            },
            Attractions = new()
            {
                new("Monad Shoal", "Dive site", "🦈", "A sunken plateau where thresher sharks come to be cleaned by small fish at dawn."),
                new("Bounty Beach", "Beach", "🏖️", "Malapascua's main stretch of white sand with restaurants and dive shops."),
                new("Gato Island", "Dive and snorkel", "🐍", "A small island with a sea-snake sanctuary and a cave swim-through."),
            },
            Stays = new()
            {
                new("Thresher Cove Dive Resort", "Dive resort", "A dive-focused resort close to the island's main dive operators."),
                new("Blue Corals Beach Resort", "Beachfront resort", "A beachside stay near Bounty Beach."),
                new("Ocean Vida Beach & Dive Resort", "Beach and dive resort", "A stay with direct beach access and dive services."),
            },
        },

        new()
        {
            Slug = "bantayan-island",
            Name = "Bantayan Island",
            Kind = "Municipality",
            Region = "North Cebu & Islands",
            Gradient = "from-pink-500 via-rose-500 to-orange-600",
            ImageUrl = "/images/bantayan.jpg",
            Tagline = "White-sand beaches and some of the Visayas' most moving Holy Week processions.",
            Overview = "Bantayan Island is made up of three municipalities: Bantayan, Santa Fe and Madridejos. Off the northwest coast of Cebu, it offers long beaches, quiet villages and a strong Catholic tradition, and its Holy Week processions draw visitors from across the region.",
            GettingThere = "Take a bus from Cebu City's North Bus Terminal to Hagnaya Port in San Remigio (about 3 to 4 hours), then a ferry to Santa Fe (roughly an hour and a half).",
            FestivalName = "Holy Week processions",
            FestivalNote = "Held during Semana Santa, the processions carry old religious images through the streets, a tradition that is deeply felt by the island community.",
            KnownFor = new() { "Santa Fe beaches", "Ogtong Cave", "Holy Week", "Dried fish" },
            History = new()
            {
                new("Spanish era", "The island, whose name echoes the Cebuano word for watch (bantay), becomes an important lookout against sea raiders and one of the earliest church-centred settlements in the area."),
                new("1580s", "The Church of Sts. Peter and Paul in Bantayan town traces its origins to the early Spanish period."),
                new("2013", "Typhoon Haiyan (Yolanda) strikes the island hard, and communities spend years rebuilding."),
            },
            Culture = new()
            {
                new("🕯️", "Holy Week", "Processions of old statues, candle-lit streets and family gatherings make Semana Santa the most important time of year."),
                new("🐟", "Dried fish and seafood", "Fishing is central to the island economy, and dried fish is a common pasalubong."),
                new("🥚", "Island farming", "Bantayan is also known for poultry and egg farming, an important local livelihood."),
            },
            Attractions = new()
            {
                new("Santa Fe beaches", "Beach", "🏝️", "A long run of white sand with resorts, restaurants and sunset views."),
                new("Ogtong Cave", "Cave swim", "🕳️", "A freshwater cave pool inside a small coastal cave."),
                new("Kota Beach and Bantigue Sandbar", "Beach and sandbar", "🌊", "Calm waters near Madridejos and a sandbar that shows at low tide."),
                new("Church of Sts. Peter and Paul", "Church", "⛪", "The principal church of Bantayan town and the focus of Holy Week."),
            },
            Stays = new()
            {
                new("Anika Island Resort", "Beach resort", "A beachfront resort in Santa Fe."),
                new("Budyong Beach Resort", "Beach resort", "A relaxed beachside resort in Santa Fe."),
                new("Ogtong Cave Resort", "Beach resort", "A resort in Santa Fe close to Ogtong Cave."),
            },
        },
    };
}
