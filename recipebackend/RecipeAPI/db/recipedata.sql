CREATE Table recipes(
    Id SERIAL PRIMARY KEY,
    CategoryDish VARCHAR(80),
    Title VARCHAR(100), 
    Theme VARCHAR(80),
    PrepTime VARCHAR(50),
    CookingTime VARCHAR(50),
    Portion TEXT,
    Ingredient TEXT[],
    Instruction TEXT[],
    Picture TEXT 
);

INSERT INTO 
recipes(CategoryDish, Title, Theme, PrepTime, CookingTime, Portion, Ingredient, Instruction, Picture) 
VALUES
('Snacks', 'Our perfect Guacamole', 'Vegan', '15min','0min','2 to 4', '{2 ripe avocados,1/4 teaspoon of salt, 1 tablespoon fresh lime juice or lemon juice,
 2 tablespoons to 1/4 cup of minced red onion or thinly sliced green onion, 1-2 serrano chiles, stems and seeds removed, minced,2 tablespoons cilantro - leaves and tender stems, finely chopped,A dash of freshly grated black pepper,1/2 ripe tomato, seeds and pulp removed, chopped,Red radishes or jicama, to garnish,Tortilla chips, to serve}',
 
  '{Cut the avocados in half. Remove the pit. Score the inside of the avocado with a blunt knife and scoop out the flesh with a spoon. Place in a bowl., Using a fork, roughly mash the avocado, Sprinkle with salt and lime -or lemon- juice. The acid in the lime juice will provide some balance to the richness of the avocado and will help delay the avocados from turning brown. Add the chopped onion, cilantro, black pepper, and chiles. Chili peppers vary individually in their hotness. So, start with a half of one chili pepper and add to the guacamole to your desired degree of hotness.
Remember that much of this is done to taste because of the variability in the fresh ingredients. Start with this recipe and adjust to your taste.
Chilling tomatoes hurts their flavor, so if you want to add chopped tomato to your guacamole, add it just before serving., Serve immediately, or if making a few hours ahead, place plastic wrap on the surface of the guacamole and press down to cover it and to prevent air reaching it. - The oxygen in the air causes oxidation which will turn the guacamole brown. - Refrigerate until ready to serve. }', 'https://www.simplyrecipes.com/thmb/1i9FWsdu4jT9alyWlmgsIwquBKc=/960x0/filters:no_upscale():max_bytes(150000):strip_icc()/__opt__aboutcom__coeus__resources__content_migration__simply_recipes__uploads__2018__07__Guacamole-LEAD-1-47de4e6e47464daba88a7f42155a2af3.jpg');


INSERT INTO 
recipes(CategoryDish, Title, Theme, PrepTime, CookingTime, Portion, Ingredient, Instruction, Picture) 
VALUES
('Snacks', 'Our perfect Guacamole', 'Vegan', '15min','0min','2 to 4','{2 ripe avocados,1/4 teaspoon of salt, 1 tablespoon fresh lime juice or lemon juice,
 2 tablespoons to 1/4 cup of minced red onion or thinly sliced green onion, 1-2 serrano chiles, stems and seeds removed, minced,2 tablespoons cilantro - leaves and tender stems, finely chopped,A dash of freshly grated black pepper,1/2 ripe tomato, seeds and pulp removed, chopped,Red radishes or jicama, to garnish,Tortilla chips, to serve}','{Cut the avocados in half. Remove the pit. Score the inside of the avocado with a blunt knife and scoop out the flesh with a spoon. Place in a bowl., Using a fork, roughly mash the avocado, Sprinkle with salt and lime -or lemon- juice. The acid in the lime juice will provide some balance to the richness of the avocado and will help delay the avocados from turning brown. Add the chopped onion, cilantro, black pepper, and chiles. Chili peppers vary individually in their hotness. So, start with a half of one chili pepper and add to the guacamole to your desired degree of hotness. Remember that much of this is done to taste because of the variability in the fresh ingredients. Start with this recipe and adjust to your taste. Chilling tomatoes hurts their flavor, so if you want to add chopped tomato to your guacamole, add it just before serving., Serve immediately, or if making a few hours ahead, place plastic wrap on the surface of the guacamole and press down to cover it and to prevent air reaching it. - The oxygen in the air causes oxidation which will turn the guacamole brown. - Refrigerate until ready to serve. }', 'this is our link' );


INSERT INTO 
recipes(CategoryDish, Title, Theme, PrepTime, CookingTime, Portion, Ingredient, Instruction, Picture) 
VALUES
('Snacks', 'Our perfect Guacamole', 'Vegan', '15min','0min','2 to 4','{2 ripe avocados,1/4 teaspoon of salt, 1 tablespoon fresh lime juice or lemon juice,
 2 tablespoons to 1/4 cup of minced red onion or thinly sliced green onion, 1-2 serrano chiles, stems and seeds removed, minced,2 tablespoons cilantro - leaves and tender stems, finely chopped,A dash of freshly grated black pepper,1/2 ripe tomato, seeds and pulp removed, chopped,Red radishes or jicama, to garnish,Tortilla chips, to serve}','{test }', 'this is our link' );