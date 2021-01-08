# Generated by Django 2.2.5 on 2020-09-09 19:30

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('NSW_App', '0003_auto_20200908_0621'),
    ]

    operations = [
        migrations.AlterField(
            model_name='game',
            name='ESRB_rating',
            field=models.CharField(blank=True, choices=[('Everyone', 'Everyone'), ('Everyone 10+', 'Everyone 10+'), ('Teen', 'Teen'), ('Mature 17+', 'Mature 17+'), ('Adults Only 18+', 'Adults Only 18+'), ('Rating Pending', 'Rating Pending')], db_column='ESRB', default='', max_length=20, null=True, verbose_name='ESRB Rating'),
        ),
        migrations.AlterField(
            model_name='game',
            name='genre',
            field=models.CharField(choices=[('Action', 'Action'), ('Adventure', 'Adventure'), ('Arcade', 'Arcade'), ('Board', 'Board'), ('Card', 'Card'), ('Casual', 'Casual'), ('Educational', 'Educational'), ('Fighting', 'Fighting'), ('Indie', 'Indie'), ('Massively-Multiplayer-Online', 'Massively-Multiplayer-Online'), ('Open-World-Game', 'Open-World-Game'), ('Platformer', 'Platformer'), ('Racing', 'Racing'), ('Role-Playing-Game', 'Role-Playing-Game'), ('Shooter', 'Shooter'), ('Simulation', 'Simulation'), ('Sports', 'Sports'), ('Strategy', 'Strategy')], db_column='genre', default='', max_length=30, null=True, verbose_name='Genre'),
        ),
        migrations.AlterField(
            model_name='game',
            name='publisher',
            field=models.CharField(blank=True, db_column='publisher', default='', max_length=50, null=True, verbose_name='Publisher'),
        ),
        migrations.AlterField(
            model_name='game',
            name='release_date',
            field=models.DateField(blank=True, db_column='release_date', default='', null=True, verbose_name='Release Date'),
        ),
        migrations.AlterField(
            model_name='game',
            name='user_rating',
            field=models.IntegerField(blank=True, choices=[(0, 0), (1, 1), (2, 2), (3, 3), (4, 4), (5, 5)], db_column='user_rating', default='', null=True, verbose_name='User Rating'),
        ),
    ]